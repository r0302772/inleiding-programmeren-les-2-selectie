using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_8
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
            Console.Title = "Exercise 8";

            //Declare variables
            string motto, backgroundcolor, foregroundcolor;

            Console.Write("What is your motto? ");
            motto = Console.ReadLine();

            Console.WriteLine("\nB. Blue" +
                              "\nR. Red" +
                              "\nY. Yellow");

            Console.Write("\nWhat background color would you like to use? ");
            backgroundcolor = Console.ReadLine().ToLower();

            Console.WriteLine("\nD. Darkgreen" +
                              "\nW. White" +
                              "\nC. Cyan");

            Console.Write("\nWhat text color would you like to use? ");
            foregroundcolor = Console.ReadLine().ToUpper();

            switch (backgroundcolor)
            {
                case "b":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "r":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "y":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
            }

            switch (foregroundcolor)
            {
                case "D":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "W":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }

            Console.Clear();

            //Results
            Console.WriteLine($"My motto is \"{motto.ToUpper()}\"!");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
