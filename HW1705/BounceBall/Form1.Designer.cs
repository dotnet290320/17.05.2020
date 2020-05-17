namespace BounceBall
{
    partial class BallFrom
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
            this.ballPic = new System.Windows.Forms.PictureBox();
            this.fallBtn = new System.Windows.Forms.Button();
            this.standonPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ballPic
            // 
            this.ballPic.Image = global::BounceBall.Properties.Resources.ball2;
            this.ballPic.Location = new System.Drawing.Point(187, 59);
            this.ballPic.Name = "ballPic";
            this.ballPic.Size = new System.Drawing.Size(144, 148);
            this.ballPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballPic.TabIndex = 0;
            this.ballPic.TabStop = false;
            // 
            // fallBtn
            // 
            this.fallBtn.Location = new System.Drawing.Point(48, 110);
            this.fallBtn.Name = "fallBtn";
            this.fallBtn.Size = new System.Drawing.Size(100, 44);
            this.fallBtn.TabIndex = 1;
            this.fallBtn.Text = "F A L L";
            this.fallBtn.UseVisualStyleBackColor = true;
            this.fallBtn.Click += new System.EventHandler(this.fallBtn_Click);
            // 
            // standonPnl
            // 
            this.standonPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.standonPnl.Location = new System.Drawing.Point(159, 197);
            this.standonPnl.Name = "standonPnl";
            this.standonPnl.Size = new System.Drawing.Size(206, 10);
            this.standonPnl.TabIndex = 2;
            // 
            // BallFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 398);
            this.Controls.Add(this.standonPnl);
            this.Controls.Add(this.fallBtn);
            this.Controls.Add(this.ballPic);
            this.Name = "BallFrom";
            this.Text = "Bounce Ball";
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ballPic;
        private System.Windows.Forms.Button fallBtn;
        private System.Windows.Forms.Panel standonPnl;
    }
}

