using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5
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
            Console.Title = "Exercise 5";

            //Declare variables
            int score;
            string arrowLanded;

            Console.WriteLine("\t1. Arrow lands outside the board (0 points)");
            Console.WriteLine("\t2. Arrow lands outer ring (20 points)");
            Console.WriteLine("\t3. Arrow lands inner ring (50 points)");
            Console.WriteLine("\t4. Arrow lands inside the bull's eye (100 points)");

            Console.Write("\n\tWhere did you your arrow land? ");
            arrowLanded = Console.ReadLine();

            switch (arrowLanded)
            {
                case "1":
                    score = 0;
                    break;
                case "2":
                    score = 20;
                    break;
                case "3":
                    score = 50;
                    break;
                case "4":
                    score = 100;
                    break;
                default:
                    score = 0;
                    break;
            }

            //Results
            Console.WriteLine($"\n\tYou scored {score} points!");

            Console.WriteLine("\n\tPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
