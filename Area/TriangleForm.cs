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
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(SideTxt1.Text, out double side1) &&
                double.TryParse(SideTxt2.Text, out double side2) &&
                double.TryParse(SideTxt3.Text, out double side3))
            {
                if (IsValidTriangle(side1, side2, side3))
                {
                    double perimeter = side1 + side2 + side3;
                    double semiPerimeter = perimeter / 2;
                    double area = Math.Sqrt(semiPerimeter *
                        (semiPerimeter - side1) *
                        (semiPerimeter - side2) *
                        (semiPerimeter - side3));

                    MessageBox.Show($"Area: {area}\nPerimeter: {perimeter}", "Triangle Calculation");
                }
                else
                {
                    MessageBox.Show("This is not a valid triangle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidTriangle(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 &&
                   side2 + side3 > side1 &&
                   side1 + side3 > side2;
        }
    }
}
