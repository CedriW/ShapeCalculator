using System;
using System.Windows.Forms;

namespace Area
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm();
            triangleForm.ShowDialog();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            RectangleForm rectangleForm = new RectangleForm();
            rectangleForm.ShowDialog();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            CircleForm circleForm = new CircleForm();
            circleForm.ShowDialog();
        }
    }
}
