
namespace SnakeGame
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.gameField = new System.Windows.Forms.PictureBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.score_val = new System.Windows.Forms.Label();
            this.gameMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStngsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).BeginInit();
            this.gameMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameField
            // 
            this.gameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameField.Location = new System.Drawing.Point(12, 59);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(700, 400);
            this.gameField.TabIndex = 0;
            this.gameField.TabStop = false;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(12, 32);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(0, 15);
            this.scoreLbl.TabIndex = 1;
            // 
            // score_val
            // 
            this.score_val.AutoSize = true;
            this.score_val.Location = new System.Drawing.Point(750, 126);
            this.score_val.Name = "score_val";
            this.score_val.Size = new System.Drawing.Size(0, 15);
            this.score_val.TabIndex = 2;
            // 
            // gameMenuStrip
            // 
            this.gameMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem});
            this.gameMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.gameMenuStrip.Name = "gameMenuStrip";
            this.gameMenuStrip.Size = new System.Drawing.Size(724, 24);
            this.gameMenuStrip.TabIndex = 3;
            this.gameMenuStrip.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameMenuItem,
            this.gameStngsMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameMenuItem.Text = "&Game";
            // 
            // startGameMenuItem
            // 
            this.startGameMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startGameMenuItem.Name = "startGameMenuItem";
            this.startGameMenuItem.Size = new System.Drawing.Size(156, 22);
            this.startGameMenuItem.Text = "&Start new game";
            // 
            // gameStngsMenuItem
            // 
            this.gameStngsMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameStngsMenuItem.Name = "gameStngsMenuItem";
            this.gameStngsMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gameStngsMenuItem.Text = "&Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 467);
            this.Controls.Add(this.score_val);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.gameField);
            this.Controls.Add(this.gameMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.gameMenuStrip;
            this.Name = "MainView";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.gameField)).EndInit();
            this.gameMenuStrip.ResumeLayout(false);
            this.gameMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox gameField;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label score_val;
        private System.Windows.Forms.MenuStrip gameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStngsMenuItem;
    }
}

