namespace Targil2
{
    partial class RandomNumbersForm
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
            this.numberLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberLbl
            // 
            this.numberLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberLbl.Location = new System.Drawing.Point(0, 0);
            this.numberLbl.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.numberLbl.Size = new System.Drawing.Size(571, 68);
            this.numberLbl.TabIndex = 0;
            this.numberLbl.Text = "?";
            this.numberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(172, 186);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(248, 67);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next Number";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // RandomNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 319);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.numberLbl);
            this.Name = "RandomNumbersForm";
            this.Text = "Random Numbers";
            this.Load += new System.EventHandler(this.RandomNumbersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Button nextBtn;
    }
}

