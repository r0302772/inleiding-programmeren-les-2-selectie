using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_9
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
            Console.Title = "Exercise 9";

            //Declare variables
            int number1, number2, number3, result, highest;
            string letter, message;

            //Ask the user for the first number
            Console.Write("Give a first number: ");
            //Read input of the user and put it into a variable
            number1 = int.Parse(Console.ReadLine());
            //int.Parse will convert the input of type string to type integer

            //Ask the user for the second number
            Console.Write("Give a second number: ");
            number2 = int.Parse(Console.ReadLine());

            //Ask the user for the third number
            Console.Write("Give a third number: ");
            number3 = int.Parse(Console.ReadLine());

            //Ask the user for the letter code
            Console.Write("Choose a letter (A, B, C, D or an other letter): ");
            letter = Console.ReadLine().ToLower();

            //Calculations
            if (letter == "a")
            {
                result = number1 + number2 + number3;
                message = $"{number1} + {number2} + {number3} = {result}";
            }
            else if (letter == "b")
            {
                result = number1 * number3;
                message = $"{number1} * {number3} = {result}";
            }
            else if (letter == "c")
            {
                result = number3 - number2;
                message = $"{number3} - {number2} = {result}";
            }
            else if (letter == "d")
            {
                if (number1 > 0)
                {
                    message = $"The square root of {number1} is {Math.Sqrt(number1)}";
                }
                else
                {
                    message = "Sorry, we don't calculate the square roots of negative numbers or zero!";
                }
            }
            else
            {
                if (number1 > number2)
                {
                    highest = number1;
                }
                else
                {
                    highest = number2;
                }

                if (number3 > highest)
                {
                    highest = number3;
                }

                message = $"Highest number of set: {number1}, {number2}, {number3} ==> {highest}";
            }

            //Results
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter

        }
    }
}
