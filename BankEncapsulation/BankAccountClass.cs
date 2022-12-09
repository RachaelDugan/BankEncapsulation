using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccountClass
    {
        private double _balance = 0;
        public BankAccountClass()
        {
        }
        public void Deposit(double depositAmount)
        {
            _balance += depositAmount;
        }
        public double GetBalance() 
        {
            return _balance;
        }
    }
}
