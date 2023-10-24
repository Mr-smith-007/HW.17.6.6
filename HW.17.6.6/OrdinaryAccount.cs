﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW._17._6._6
{
    internal class OrdinaryAccount : IAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        internal OrdinaryAccount(double balance)
        {
            Type = "Обычный";
            Balance = balance;
        }

        public void CalculateInterest()
        {
            this.Interest = this.Balance * 0.4;
            if (this.Balance < 1000)
                this.Interest -= this.Balance * 0.2;

            if (this.Balance >= 1000)
                this.Interest -= this.Balance * 0.4;
        }
    }
}
