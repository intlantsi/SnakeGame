using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeGame.Models;
using SnakeGame.Models.Enums;

namespace SnakeGame
{
    public partial class MainView : Form
    {
        public MainView()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            Settings = new SnakeStngs() { Speed = 1, FieldSize = gameField.Size };

            this.KeyDown += MainViewKeyDown;
            gameField.Paint += GameFieldPaint;

            startGameMenuItem.Click += StartGameMenuItemClick;
            gameStngsMenuItem.Click += GameStngsMenuItemClick;
            exitToolStripMenuItem.Click += ExitToolStripMenuItemClick;
        }



        #region Properties
        public Snake SnakeGame { get; set; }
        public SnakeStngs Settings { get; set; }
        private List<Point> PointsToDraw { get; set; } = new List<Point>();
        #endregion

        #region Event handlers
        private void MainViewKeyDown(object sender, KeyEventArgs e)
        {
            if (SnakeGame != null)
            {
                if (SnakeGame.InProgress)
                {
                    var direction = e.KeyCode switch
                    {
                        Keys.Up => Direction.Up,
                        Keys.Down => Direction.Down,
                        Keys.Left => Direction.Left,
                        Keys.Right => Direction.Right
                    };
                    SnakeGame.ChangeHeadDirection(direction);
                }

                if (!SnakeGame.InProgress && SnakeGame.StartGame())
                {
                    scoreLbl.Text = "Score: 0";
                }
            }
        }

        private void GameFieldPaint(object sender, PaintEventArgs e)
        {
            PointsToDraw.ForEach(x =>
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(x, new Size(10, 10)));
            });
        }

        private void SnakeChangedHandler(object sender, List<Point> e)
        {
            PointsToDraw = e;
            gameField.Invoke((Action)(() => gameField.Refresh()));
        }

        private void GameOverHandler(object sender, bool e)
        {
            MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ScoreChangedHandler(object sender, int e)
        {
            scoreLbl.Invoke((Action)(() => scoreLbl.Text=$"Score: {e}"));
        }

        private void StartGameMenuItemClick(object sender, System.EventArgs e)
        {
            this.Size = new Size(Settings.FieldSize.Width + 40, Settings.FieldSize.Height + 106);

            if (SnakeGame != null)
                SnakeGame.Dispose();

            SnakeGame = new Snake(Settings);
            SnakeGame.SnakeChanged += SnakeChangedHandler;
            SnakeGame.GameOver += GameOverHandler;
            SnakeGame.ScoreChanged += ScoreChangedHandler;

            scoreLbl.Text = "Press any key to start...";
        }

        private void GameStngsMenuItemClick(object sender, EventArgs e)
        {
            SettingsView stngs = new SettingsView(Settings);
            stngs.ShowDialog();
        }

        private void ExitToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            SnakeGame.Dispose();
            Application.Exit();
        }
        #endregion

    }
}
