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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(radiusTxt.Text, out double radius))
            {
                double area = Math.PI * radius * radius;
                double circumference = 2 * Math.PI * radius;

                MessageBox.Show($"Area: {area}\nCircumference: {circumference}", "Circle Calculation");
            }
            else
            {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
