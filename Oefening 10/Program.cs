using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_10
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
            Console.Title = "Exercise 10";

            //Declare variables
            string lastname, firstname, hobby, magazine;

            Console.Write("\tWhat's your last name: ");
            lastname = Console.ReadLine().ToUpper();

            Console.Write("\tWhat's your first name: ");
            firstname = Console.ReadLine().ToLower();

            Console.WriteLine("\n\t1. Handicrafts (knitting, crocheting, ...)" +
                              "\n\t2. Making clothing" +
                              "\n\t3. Decorating the interior" +
                              "\n\t4. Playing football" +
                              "\n\t5. Riding a bike" +
                              "\n\t6. Photography" +
                              "\n\t7. Running");

            Console.Write($"\n\t{firstname} {lastname}, what hobby do you practice? ");
            hobby = Console.ReadLine();

            switch (hobby)
            {
                case "1":
                    magazine = "Anna";
                    break;
                case "2":
                    magazine = "Cutie";
                    break;
                case "3":
                    magazine = "VtLiving";
                    break;
                case "4":
                    magazine = "Football International";
                    break;
                case "5":
                    magazine = "Hiking & Cycling";
                    break;
                case "6":
                    magazine = "Zoom NL";
                    break;
                case "7":
                    magazine = "Runners";
                    break;
                default:
                    magazine = "none";
                    break;
            }

            //Results
            //Set backgroundcolor to yellow
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\tWe suggest as magazine: \"" + magazine + "\".");

            //Set backgroundcolor back to white
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\n\tPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
