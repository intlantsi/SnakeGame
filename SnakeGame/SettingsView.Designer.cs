
namespace SnakeGame
{
    partial class SettingsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speedLbl = new System.Windows.Forms.Label();
            this.fieldSizeLbl = new System.Windows.Forms.Label();
            this.fieldWdthLbl = new System.Windows.Forms.Label();
            this.fieldHghtLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.snakeSpdValue = new System.Windows.Forms.NumericUpDown();
            this.fieldWdthValue = new System.Windows.Forms.NumericUpDown();
            this.fieldHghtValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldWdthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldHghtValue)).BeginInit();
            this.SuspendLayout();
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(15, 18);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(75, 15);
            this.speedLbl.TabIndex = 0;
            this.speedLbl.Text = "Snake speed:";
            // 
            // fieldSizeLbl
            // 
            this.fieldSizeLbl.AutoSize = true;
            this.fieldSizeLbl.Location = new System.Drawing.Point(15, 51);
            this.fieldSizeLbl.Name = "fieldSizeLbl";
            this.fieldSizeLbl.Size = new System.Drawing.Size(54, 15);
            this.fieldSizeLbl.TabIndex = 2;
            this.fieldSizeLbl.Text = "Field size";
            // 
            // fieldWdthLbl
            // 
            this.fieldWdthLbl.AutoSize = true;
            this.fieldWdthLbl.Location = new System.Drawing.Point(15, 80);
            this.fieldWdthLbl.Name = "fieldWdthLbl";
            this.fieldWdthLbl.Size = new System.Drawing.Size(42, 15);
            this.fieldWdthLbl.TabIndex = 3;
            this.fieldWdthLbl.Text = "Width:";
            // 
            // fieldHghtLbl
            // 
            this.fieldHghtLbl.AutoSize = true;
            this.fieldHghtLbl.Location = new System.Drawing.Point(15, 111);
            this.fieldHghtLbl.Name = "fieldHghtLbl";
            this.fieldHghtLbl.Size = new System.Drawing.Size(43, 15);
            this.fieldHghtLbl.TabIndex = 4;
            this.fieldHghtLbl.Text = "Heght:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(79, 160);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "OK";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // snakeSpdValue
            // 
            this.snakeSpdValue.Location = new System.Drawing.Point(96, 16);
            this.snakeSpdValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.snakeSpdValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snakeSpdValue.Name = "snakeSpdValue";
            this.snakeSpdValue.Size = new System.Drawing.Size(120, 23);
            this.snakeSpdValue.TabIndex = 6;
            this.snakeSpdValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fieldWdthValue
            // 
            this.fieldWdthValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldWdthValue.Location = new System.Drawing.Point(96, 72);
            this.fieldWdthValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldWdthValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fieldWdthValue.Name = "fieldWdthValue";
            this.fieldWdthValue.Size = new System.Drawing.Size(120, 23);
            this.fieldWdthValue.TabIndex = 7;
            this.fieldWdthValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // fieldHghtValue
            // 
            this.fieldHghtValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldHghtValue.Location = new System.Drawing.Point(96, 109);
            this.fieldHghtValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldHghtValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fieldHghtValue.Name = "fieldHghtValue";
            this.fieldHghtValue.Size = new System.Drawing.Size(120, 23);
            this.fieldHghtValue.TabIndex = 8;
            this.fieldHghtValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 195);
            this.Controls.Add(this.fieldHghtValue);
            this.Controls.Add(this.fieldWdthValue);
            this.Controls.Add(this.snakeSpdValue);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fieldHghtLbl);
            this.Controls.Add(this.fieldWdthLbl);
            this.Controls.Add(this.fieldSizeLbl);
            this.Controls.Add(this.speedLbl);
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldWdthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldHghtValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.Label fieldSizeLbl;
        private System.Windows.Forms.Label fieldWdthLbl;
        private System.Windows.Forms.Label fieldHghtLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown snakeSpdValue;
        private System.Windows.Forms.NumericUpDown fieldWdthValue;
        private System.Windows.Forms.NumericUpDown fieldHghtValue;
    }
}