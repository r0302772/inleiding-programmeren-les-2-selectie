using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
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
            Console.Title = "Exercise 3";

            //Declare variables
            int age;
            string firstname, lastname, ageGroup = "Adult";

            //Ask the user for their first name
            Console.Write("Your first name: ");
            //Read input of the user and put it into a variable
            firstname = Console.ReadLine();
            //int.Parse will convert the input of type string to type integer

            //Ask the user for their last name
            Console.Write($"{firstname}, put in your last name: ");
            lastname = Console.ReadLine();

            //Ask the user for their age
            //Change text color to red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{firstname} {lastname}");

            //Change text color back to darkblue
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(", what is your age ? ");
            age = int.Parse(Console.ReadLine());

            //Results
            Console.Write($"\n{firstname} {lastname} belongs to the age group: ");

            //Calculations
            if (age < 18)
            {
                //Change text color to darkgreen
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //Set age group to youth
                ageGroup = "Youth";
            }

            Console.WriteLine($"{ageGroup}");

            //Change text color back to darkblue
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
