using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_7
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
            Console.Title = "Exercise 7";

            //Declare variables
            int number1, number2, number3, number4, lowest;

            //Ask the user for the first number
            Console.Write("Give a first number: ");
            //Read input of the user and put it into a variable
            number1 = int.Parse(Console.ReadLine());
            //int.Parse will convert the input of type string to type integer

            //Ask the user for the second number
            Console.Write("Give a second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Give a third number: ");
            number3 = int.Parse(Console.ReadLine());

            Console.Write("Give a fourth number: ");
            number4 = int.Parse(Console.ReadLine());

            //Calculations
            if (number1 < number2)
            {
                lowest = number1;
            }
            else
            {
                lowest = number2;
            }

            if (number3 < lowest)
            {
                lowest = number3;
            }

            if (number4 < lowest)
            {
                lowest = number4;
            }

            //Results
            Console.WriteLine($"\nFrom the set {number1}, {number2}, {number3} and {number4}, the lowest number is {lowest}.");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
