using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleAPP
{
    public partial class Circle1 : Form
    {
        public Circle1()
        {
            InitializeComponent();
        }
       
            Circle aCircle  ;
        private void perimeterButton_Click(object sender, EventArgs e)
        {
            aCircle = new Circle(Convert.ToDouble(radiusTextBox.Text));
            MessageBox.Show("Perimeter: " + aCircle.GetPerimeter());
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diameter: " + aCircle.GetDiameter());
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area: " + aCircle.GetArea());
        }
    }
}
