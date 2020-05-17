using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Targil2
{
    public partial class RandomNumbersForm : Form
    {
        int[] numbers;
        public const int ARRAY_SIZE = 10;
        public const int RANDOM_MIN = 1;
        public const int RANDOM_MAX = 100;
        Random random_generator = new Random();
        int location_inside_array = 0;

        public RandomNumbersForm()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            numberLbl.ForeColor = Color.Black;

            numberLbl.Text = numbers[location_inside_array].ToString();

            //location_inside_array = location_inside_array + 1;
            location_inside_array++;

            if (location_inside_array == numbers.Length)
            {
                numberLbl.ForeColor = Color.Red;
                location_inside_array = 0;
            }
        }

        private void RandomNumbersForm_Load(object sender, EventArgs e)
        {
            numbers = new int[ARRAY_SIZE];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random_generator.Next(RANDOM_MIN,
                    RANDOM_MAX + 1);
            }
        }
    }
}
