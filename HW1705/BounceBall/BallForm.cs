using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BounceBall
{
    public partial class BallFrom : Form
    {
        public BallFrom()
        {
            InitializeComponent();
        }

        private void fallBtn_Click(object sender, EventArgs e)
        {
            standonPnl.Visible = false;
            int gotoY = Size.Height - ballPic.Height - 25;
            
            for (int i = ballPic.Location.Y; i <= gotoY; i = i + 10)
            {
                ballPic.Location = new Point(ballPic.Location.X, i);
                Thread.Sleep(100);
            }
        }
    }
}
