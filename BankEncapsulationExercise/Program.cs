using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Five = new BankAccount();
            int userchoice = 0;
            double depoAmt = 0;

            Console.WriteLine("Hello user number 5 \n");
            do
            {

                switch (userchoice)
                {
                    case 0:
                    Console.WriteLine("\n press 1 to make a deposit. \n press 2 to view balance. \n press 3 to exit.");
                    if (Int32.TryParse(Console.ReadLine(), out userchoice))
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("invalid input. try again");
                        userchoice = 0;
                        break;
                    }
                    

                    case 1:
                        Console.WriteLine("How much would you like to deposit? \n");
                        if (Double.TryParse(Console.ReadLine(), out depoAmt))
                        {

                            Five.Deposit(depoAmt);
                            userchoice = 0;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("try again and use only numbers");    
                            userchoice = 0;
                            break;

                        }

                    case 2:
                        Console.WriteLine($" Your current balance is {Five.GetBalance()}");
                        userchoice = 0;
                        break;

                    case 3:
                        Console.WriteLine("Have a nice day!");
                        break;

                    default:
                        Console.WriteLine("Invalid input.  try again.");
                        userchoice = 0;
                        break;
                }


            }
            while (userchoice != 3);

        }
    }
}
