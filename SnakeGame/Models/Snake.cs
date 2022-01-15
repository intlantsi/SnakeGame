using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using SnakeGame.Models.Enums;

namespace SnakeGame.Models
{
    public class Snake:IDisposable
    {
        #region Fields
        int score;
        #endregion

        public Snake(SnakeStngs settings)
        {
            InProgress = false;

            GameCycle = new System.Timers.Timer(1000/(settings.Speed*3));
            GameCycle.Elapsed += GameStateUpdate;

            FoodRandom = new Random();
            FieldSize = settings.FieldSize;
            SnakeHead = new SnakePiece(null) { Position = settings.StartPoint, MoveDirection=Direction.Right };
            SnakePieces.Add(SnakeHead);
            FoodPosition = AddFood();

            Score = 0;
            ScoreChanged?.Invoke(this, Score);
        }

        #region Properties
        private Size FieldSize { get; }
        private Random FoodRandom { get; }
        private Point FoodPosition { get; set; }
        private System.Timers.Timer GameCycle { get; }
        public static int FieldStep { get; } = 10;
        private bool InUpdate { get; set; }
        public int Score 
        { 
            get=>score; 
            private set
            {
                if (score!=value)
                {
                    score = value;
                    ScoreChanged?.Invoke(this, score);
                }
            }
        }
        private SnakePiece SnakeHead { get; }
        private List<SnakePiece> SnakePieces { get; } = new List<SnakePiece>();
        public bool InProgress { get; private set; }
        #endregion

        #region Methods
        private void GameStateUpdate(object sender, ElapsedEventArgs e)
        {
            InUpdate = true;

            if (CheckSnakeInterSection())
            {
                GameCycle.Stop();
                InProgress = GameCycle.Enabled;

                GameOver?.Invoke(this, true);
            }

            if (SnakeHead.Position.X == FoodPosition.X
                && SnakeHead.Position.Y == FoodPosition.Y)
            {
                Score++;
                FoodPosition = AddFood();
                SnakePieces.Add(new SnakePiece(SnakePieces.Last()));
            }

            for (int i = SnakePieces.Count - 1; i > -1; i--)
                SnakePieces[i].CalculatePosition();

            SnakeChanged?.Invoke(this, GetPointsToDraw());

            InUpdate = false;
        }

        private Point AddFood()
        {
            Point foodPnt;
            bool foodPntOk = true;
            do
            {
                int foodX = FoodRandom.Next(0, FieldSize.Width - FieldStep);
                int foodY = FoodRandom.Next(0, FieldSize.Height - FieldStep);

                foodPnt = new Point(foodX - foodX % FieldStep, foodY - foodY % FieldStep);
                foodPntOk=SnakePieces.Any(x => x.Position == foodPnt);

            } while (foodPntOk);
            return foodPnt;
        }

        private List<Point> GetPointsToDraw()
        {
            List<Point> pntsToDraw = new List<Point>();
            pntsToDraw.Add(FoodPosition);
            pntsToDraw.AddRange(SnakePieces.Select(x => x.Position));
            return pntsToDraw;
        }
        
        private bool CheckSnakeInterSection()
        {
            if (SnakeHead.Position.X < 0 || SnakeHead.Position.X >= FieldSize.Width ||
                SnakeHead.Position.Y < 0 || SnakeHead.Position.Y >= FieldSize.Height ||
                SnakePieces.Skip(1).Any(x=>x.Position==SnakeHead.Position))
            {
                return true;
            }
            return false;
        }

        public bool StartGame()
        {
            GameCycle.Start();
            InProgress = GameCycle.Enabled;

            return InProgress;
        }

        public void ChangeHeadDirection(Direction drct)
        {
            if(InUpdate) return;
            if(SnakePieces.Count>1)
            {
                if (Math.Abs(SnakePieces[1].MoveDirection - drct) == 1)
                    return;
            }
            SnakeHead.MoveDirection = drct;
        }
        #endregion

        #region Events
        public event EventHandler<List<Point>> SnakeChanged;
        public event EventHandler<int> ScoreChanged;
        public event EventHandler<bool> GameOver;
        #endregion

        #region IDisposable
        public void Dispose()
        {
            SnakeChanged = null;
            GameOver = null;
            ScoreChanged = null;
            GameCycle.Stop();
        }
        #endregion
    }
}
