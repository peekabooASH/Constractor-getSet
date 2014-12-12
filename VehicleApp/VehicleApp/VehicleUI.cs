using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        Vehicle avehiclel;
        
        private void button1_Click(object sender, EventArgs e)
        {
            avehiclel = new Vehicle(vehicalNameTextBox.Text, regTextBox.Text);
            vehicalNameTextBox.Text = "";
            regTextBox.Text = "";
            MessageBox.Show("You are Registered.");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
         avehiclel.Speed(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minspeedTextBox.Text = avehiclel.ShowMinSpeed();
            maxspeedTextBox.Text = avehiclel.ShowMaxSpeed();
            averagespeedTextBox.Text=avehiclel.ShowAverageSpeed();
        }

        
    }
}
