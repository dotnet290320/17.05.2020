namespace Simon
{
    partial class SimonWindow
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
            this.redPnl = new System.Windows.Forms.Panel();
            this.yellowPnl = new System.Windows.Forms.Panel();
            this.greenPnl = new System.Windows.Forms.Panel();
            this.bluePnl = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roundLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redPnl
            // 
            this.redPnl.BackColor = System.Drawing.Color.Red;
            this.redPnl.Location = new System.Drawing.Point(33, 35);
            this.redPnl.Name = "redPnl";
            this.redPnl.Size = new System.Drawing.Size(233, 182);
            this.redPnl.TabIndex = 0;
            this.redPnl.Tag = "1";
            this.redPnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // yellowPnl
            // 
            this.yellowPnl.BackColor = System.Drawing.Color.Yellow;
            this.yellowPnl.Location = new System.Drawing.Point(288, 35);
            this.yellowPnl.Name = "yellowPnl";
            this.yellowPnl.Size = new System.Drawing.Size(233, 182);
            this.yellowPnl.TabIndex = 1;
            this.yellowPnl.Tag = "2";
            this.yellowPnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // greenPnl
            // 
            this.greenPnl.BackColor = System.Drawing.Color.Lime;
            this.greenPnl.Location = new System.Drawing.Point(288, 238);
            this.greenPnl.Name = "greenPnl";
            this.greenPnl.Size = new System.Drawing.Size(233, 182);
            this.greenPnl.TabIndex = 3;
            this.greenPnl.Tag = "4";
            this.greenPnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // bluePnl
            // 
            this.bluePnl.BackColor = System.Drawing.Color.Blue;
            this.bluePnl.Location = new System.Drawing.Point(33, 238);
            this.bluePnl.Name = "bluePnl";
            this.bluePnl.Size = new System.Drawing.Size(233, 182);
            this.bluePnl.TabIndex = 2;
            this.bluePnl.Tag = "3";
            this.bluePnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(193, 446);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(175, 75);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Round:";
            // 
            // roundLbl
            // 
            this.roundLbl.AutoSize = true;
            this.roundLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roundLbl.Location = new System.Drawing.Point(91, 433);
            this.roundLbl.Name = "roundLbl";
            this.roundLbl.Size = new System.Drawing.Size(16, 20);
            this.roundLbl.TabIndex = 6;
            this.roundLbl.Text = "-";
            // 
            // SimonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 544);
            this.Controls.Add(this.roundLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.greenPnl);
            this.Controls.Add(this.yellowPnl);
            this.Controls.Add(this.bluePnl);
            this.Controls.Add(this.redPnl);
            this.Name = "SimonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon Game";
            this.Load += new System.EventHandler(this.SimonWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel redPnl;
        private System.Windows.Forms.Panel yellowPnl;
        private System.Windows.Forms.Panel greenPnl;
        private System.Windows.Forms.Panel bluePnl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roundLbl;
    }
}

