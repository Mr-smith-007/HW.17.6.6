using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._17._6._6
{
    internal class Calculator
    {
        internal IAccount _account;
        internal Calculator(IAccount a)
        {
            _account = a;
        }

        internal void Calculate()
        {
            _account.CalculateInterest();
            Console.WriteLine($"Проект: {_account.Type}, баланс: {_account.Balance}. Процентная ставка: {_account.Interest}");
        }



    }
}
