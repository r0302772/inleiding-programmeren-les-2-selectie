using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
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
            Console.Title = "Exercise 1";

            //Declare variables
            int number1, number2;
            string message;

            //Ask the user for the first number
            Console.Write("Give a first number: ");
            //Read input of the user and put it into a variable
            number1 = int.Parse(Console.ReadLine());
            //int.Parse will convert the input of type string to type integer

            //Ask the user for the second number
            Console.Write("Give a second number: ");
            number2 = int.Parse(Console.ReadLine());

            //Calculations

            //Two ways to use the if statement: long and short

            //Long

            //if (number1 > number2)
            //{
            //    result = number1 - number2;
            //    message = $"{number1} - {number2} = {number1 - number2}";
            //}
            //else
            //{
            //    result = number2 - number1;
            //    message = $"{number2} - {number1} = {number2 - number1}";
            //}

            //Short
            message = (number1 > number2) ? $"{number1} - {number2} = {number1 - number2}" : $"{number2} - {number1} = {number2 - number1}";

            //Results
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
