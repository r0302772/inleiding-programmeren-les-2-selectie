using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
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
            Console.Title = "Exercise 2";

            //Declare variables
            int number1, number2;
            string message;

            //Ask the user for the first round number
            Console.Write("Give a first round number: ");
            //Read input of the user and put it into a variable
            number1 = int.Parse(Console.ReadLine());
            //int.Parse will convert the input of type string to type integer

            //Ask the user for the second round number
            Console.Write("Give a second round number: ");
            number2 = int.Parse(Console.ReadLine());

            //Calculations
            message = (number1 == 0 || number2 == 0) ? $"{number1} is not divisible by 0!" : $"{number1} / {number2} = {number1 / number2}";

            //Results
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
