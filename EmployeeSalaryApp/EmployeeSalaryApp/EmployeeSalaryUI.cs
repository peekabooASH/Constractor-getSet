using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private Salary aSalary;
        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            aSalary = new Salary(employeeNameTextBox.Text, Convert.ToDouble(basicAmountTextBox.Text), Convert.ToDouble(houseRentTextBox.Text), Convert.ToDouble(medicalAllowanceTextBox.Text));
            double total = aSalary.GetTotal();
            MessageBox.Show(Name + " your salary is: " + total);
        }
    }
}
