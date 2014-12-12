using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
       
        private string number;
        private string name;
        private double balance;

        public string Number { private get; set; }
        public string Name { private get; set; }
        public double Balance {  get; private set; }
        public Account(string number, string name)
        {
            Number = number;
            Name = name;
        }
      
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public string GetReport()
        {
            string msg = Name + " your account no : " + Number + " and it's balance is : " + balance;
            return msg;
        }

    }
}
