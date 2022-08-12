using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
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
            Console.Title = "Exercise 4";

            //Declare variables
            int number1, number2, number3, first, second, result;
            string letter, figure, message;

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
            Console.Write("Choose a letter (A or B): ");
            letter = Console.ReadLine();

            //Ask the user for a figure code
            Console.Write("Choose a figure (1 or 2 or 3): ");
            figure = Console.ReadLine();

            //Calculations
            if (figure == "1")
            {
                first = number1;
                second = number2;
            }
            else
            {
                if (figure == "2")
                {
                    first = number2;
                    second = number3;
                }
                else
                {
                    first = number1;
                    second = number3;
                }
            }

            if (letter.ToUpper() == "A")
            {
                result = first + second;
                message = $"{first} + {second} = {result}";
            }
            else
            {
                result = first - second;
                message = $"{first} - {second} = {result}";
            }

            //Results
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
