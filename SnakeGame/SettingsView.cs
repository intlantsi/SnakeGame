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

namespace SnakeGame
{
    public partial class SettingsView : Form
    {
        public SettingsView(SnakeStngs settings)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            Settings = settings;
            snakeSpdValue.Value = Settings.Speed;
            fieldWdthValue.Value = Settings.FieldSize.Width;
            fieldHghtValue.Value = Settings.FieldSize.Height;

            this.FormClosed += SettingsViewFormClosed;
        }

        private SnakeStngs Settings { get; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsViewFormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Speed = (int)snakeSpdValue.Value;
            Settings.FieldSize = new Size((int)fieldWdthValue.Value, (int)fieldHghtValue.Value);
        }
    }
}
