namespace HW1705
{
    partial class Targil1Form
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
            this.bluePnl = new System.Windows.Forms.Panel();
            this.greenPnl = new System.Windows.Forms.Panel();
            this.yelloPnl = new System.Windows.Forms.Panel();
            this.colorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redPnl
            // 
            this.redPnl.BackColor = System.Drawing.Color.Red;
            this.redPnl.Location = new System.Drawing.Point(1, 196);
            this.redPnl.Name = "redPnl";
            this.redPnl.Size = new System.Drawing.Size(140, 122);
            this.redPnl.TabIndex = 0;
            this.redPnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // bluePnl
            // 
            this.bluePnl.BackColor = System.Drawing.Color.Blue;
            this.bluePnl.Location = new System.Drawing.Point(141, 196);
            this.bluePnl.Name = "bluePnl";
            this.bluePnl.Size = new System.Drawing.Size(140, 122);
            this.bluePnl.TabIndex = 1;
            this.bluePnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // greenPnl
            // 
            this.greenPnl.BackColor = System.Drawing.Color.Lime;
            this.greenPnl.Location = new System.Drawing.Point(282, 196);
            this.greenPnl.Name = "greenPnl";
            this.greenPnl.Size = new System.Drawing.Size(140, 122);
            this.greenPnl.TabIndex = 1;
            this.greenPnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // yelloPnl
            // 
            this.yelloPnl.BackColor = System.Drawing.Color.Yellow;
            this.yelloPnl.Location = new System.Drawing.Point(423, 196);
            this.yelloPnl.Name = "yelloPnl";
            this.yelloPnl.Size = new System.Drawing.Size(140, 122);
            this.yelloPnl.TabIndex = 1;
            this.yelloPnl.Click += new System.EventHandler(this.AnyPnl_Click);
            // 
            // colorLbl
            // 
            this.colorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.colorLbl.Location = new System.Drawing.Point(1, 82);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(562, 34);
            this.colorLbl.TabIndex = 2;
            this.colorLbl.Text = "I am a Color!";
            this.colorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Targil1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 319);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.bluePnl);
            this.Controls.Add(this.greenPnl);
            this.Controls.Add(this.yelloPnl);
            this.Controls.Add(this.redPnl);
            this.Name = "Targil1Form";
            this.Text = "Panels Coloring";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel redPnl;
        private System.Windows.Forms.Panel bluePnl;
        private System.Windows.Forms.Panel greenPnl;
        private System.Windows.Forms.Panel yelloPnl;
        private System.Windows.Forms.Label colorLbl;
    }
}

