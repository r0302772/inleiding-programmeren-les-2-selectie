using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Reset console
            Console.Clear();

            //Edit window title
            Console.Title = "Exercise 6";

            //Declare variables
            int year, remainder;
            string message = "";

            Console.WriteLine("\tDetermine leap year!");

            Console.WriteLine();

            Console.Write("\tGive a year: ");
            year = int.Parse(Console.ReadLine());

            message += $"{year} is ";

            if (year < 1582)
            {
                if (year % 4 != 0)
                {
                    message += $"not ";
                }

                message += "a leap year";
            }
            else
            {
                if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                {
                    message += "a ";
                }
                else if (year % 4 == 0 && year % 100 == 0 && year % 4000 == 0)
                {
                    message += "not a ";
                }
                else if (year % 4 == 0)
                {
                    message += "a ";
                }
                else
                {
                    message += "not a ";
                }

                message += "leap year";
            }


            Console.WriteLine();
            Console.WriteLine($"\t{message}");

            Console.WriteLine();
            Console.WriteLine("\tPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
