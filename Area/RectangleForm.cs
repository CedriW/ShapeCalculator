using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class RectangleForm : Form
    {
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(widthTxt.Text, out double width) &&
                double.TryParse(heightTxt.Text, out double height))
            {
                double area = width * height;
                double perimeter = 2 * (width + height);

                MessageBox.Show($"Area: {area}\nPerimeter: {perimeter}", "Rectangle Calculation");
            }
            else
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
