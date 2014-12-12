using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultApp
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private Result aresult;
        private void showButton_Click(object sender, EventArgs e)
        {
            aresult = new Result(Convert.ToDouble(physicstextBox.Text), Convert.ToDouble(chemistrytextBox.Text), Convert.ToDouble(mathtextBox.Text));
            averagetextBox.Text=(aresult.Grade()).ToString();
            gradetextBox.Text = aresult.GradeLetter();

        }
    }
}
