using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        private string name;
        private double basic;
        private double houseRentPercent;
        private double medicalAllowancePercent;

        public string Name { private get; set; }
        public double Basic { private get; set; }
        public double HouseRentPercent { private get; set; }
        public double MedicalAllowancePercent { private get; set; }

        public Salary(string name, double basic, double houseRentPercent, double medicalAllowancePercent)
        {
            Name =name;
            Basic =basic;
            HouseRentPercent =houseRentPercent;
            MedicalAllowancePercent = medicalAllowancePercent;
        }

        public double GetMedicalAmount()
        {
            return (Basic * MedicalAllowancePercent) / 100;
        }
        public double GetHouseRentAmount()
        {
            return (Basic * HouseRentPercent) / 100;

        }
        public double GetTotal()
        {
            return Basic + GetHouseRentAmount() + GetMedicalAmount();
        }
    }
}
