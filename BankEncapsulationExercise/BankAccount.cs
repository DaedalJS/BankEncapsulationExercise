using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double Balance = 0;
        
            public void Deposit(double deposit)
            {
                Balance += deposit;
                Console.WriteLine($"{deposit} added to balance.");
            }
             
            public double GetBalance()
            {
                return Balance;
            }
            

    }
}
