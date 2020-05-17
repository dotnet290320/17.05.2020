using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1705
{
    public partial class Targil1Form : Form
    {
        public Targil1Form()
        {
            InitializeComponent();
        }

        private void AnyPnl_Click(object sender, EventArgs e)
        {
            // way 1 -- 4 if
            //if (sender == redPnl)
            //colorLbl.ForeColor = redPnl.BackColor;
            //... more ifs

            // way 2 -- switch case
            //switch (sender)
            //{
            //case redPnl:
            //colorLbl.ForeColor = redPnl.BackColor;
            //break;
            //}

            object o1 = 4;
            object o2 = "hello";
            Debug.WriteLine((o2 as string) + " world!");
            object o3 = redPnl;
            int[] arr = { 1, 2, 3 };
            object o4 = new int[] { 1, 2, 3 };
            int len = (o4 as int[]).Length;
            //Debug.WriteLine((o4 as string) + " world!"); //will fail in runtime

            // way 3 -- tell c# to treat the sender as panel
            colorLbl.ForeColor = (sender as Panel).BackColor;
        }
    }
}
