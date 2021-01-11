using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Financial_Calculator
{
    class Program
    {
        static int ReadInt(string msg)      // the static function is used so that WriteLine and ReadLine isn't redundant
        {
            WriteLine(msg);
            return Convert.ToInt16(ReadLine());
        }
        static double ReadDouble(string msg)
        {
            WriteLine(msg);
            return Convert.ToDouble(ReadLine());
        }
        
        static void Main()
        {
            int years, option;
            double money, percentage, total, power, income, save, expense;
            
            // FV = PV * (1 + i / 100)^n -- i = interest rate and n = number of years

            option = ReadInt("Welcome to the virtual financial calculator. Please enter the option's number to continue.\n1. Predict amount after certain years\n2. Create a monthly budget.");
            
            if (option > 2)
            {
                WriteLine("Sorry, {0} is not an option!" , option);
            }
            else if (option == 1)
            {
                years = ReadInt("How many years would you like to predict?");
                money = ReadDouble("How much money do you currently have?");
                percentage = ReadDouble("How much is the annual percentage interest (do not include % symbol)?");
                power = 1 + percentage / 100;
                total = money * Math.Pow(power, years);
                WriteLine("The estimated predicted amount in {0} years will be {1:c}.", years, total);
            }
            else if (option == 2)
            {
                income = ReadDouble("How much is your monthly income?");
                expense = ReadDouble("How much are your monthly expenses?");
                save = ReadDouble("How much would you like to save?");
                if (save > income)
                {
                    WriteLine("You can't save more than the amount you're making!");
                }
                else 
                {
                    WriteLine("In order to save {0:c} per month, you would need to decrease your expenses by {1:c}.", save, Math.Abs((income - save) - expense));
                }
            }

            
        } 
    }
}
