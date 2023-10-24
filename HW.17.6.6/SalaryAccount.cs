using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW._17._6._6
{
    internal class SalaryAccount :IAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        internal SalaryAccount(double balance)
        {
            Type = "Зарплатный";
            Balance = balance;
        }

        public void CalculateInterest()
        {
            this.Interest = this.Balance * 0.5;
        }
    }
}
