using System;
using System.Collections.Generic;
using CalculatorLib;

namespace Consumer
{
    class Program
    {
        const string EXIT_VALUE = "Exit";
        /// <summary>
        /// The menu options the user can choose from
        /// </summary>
        static Dictionary<int, string> options = new Dictionary<int, string> {
            {1,  "Add"},
            {2,  "Subtract"},
            {3, EXIT_VALUE}
        };

        /// <summary>
        /// Gather user input
        /// </summary>
        /// <returns>Valid user input</returns>
        static int GatherIntInput()
        {
            int? input = null;
            while (input == null)
            {
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
            return (int)input;
        }

        /// <summary>
        /// Function to gather input for arg1 and arg2
        /// </summary>
        /// <returns>tuple containing (arg1, arg2)</returns>
        static (int, int) GatherArgumentsInput()
        {
            Console.Write("Enter the first argument: ");
            int arg1 = GatherIntInput();
            Console.WriteLine();
            Console.Write("Enter the second argument: ");
            int arg2 = GatherIntInput();
            Console.WriteLine();
            return (arg1, arg2);
        }


        /// <summary>
        /// Whether the provided input corresponds to the Exit menu button
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        static bool isExit(int option)
        {
            int? exitOption = null;
            foreach (KeyValuePair<int, string> entry in options)
            {
                if (entry.Value == EXIT_VALUE) exitOption = entry.Key;
            }
            if (exitOption == null) throw new System.Exception("The menu is missing an exit option");
            return (int)exitOption == option;
        }

        static void PrintMenu()
        {
            Console.WriteLine("Welcome to the main menu. What would you like to do?");
            foreach (KeyValuePair<int, string> entry in options)
            {
                Console.WriteLine($"{entry.Key}\t{entry.Value}");
            }
        }


        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            PrintMenu();
            int input = GatherIntInput();
            while (!isExit(input))
            {
                var (arg1, arg2) = GatherArgumentsInput();
                float result = 0.0f;
                switch (input)
                {
                    case 1:
                        {
                            result = c.Add(arg1, arg2);
                            Console.WriteLine($"{arg1} + {arg2} = {result}");
                            break;
                        }
                    default:
                        {
                            result = c.Subtract(arg1, arg2);
                            Console.WriteLine($"{arg1} - {arg2} = {result}");
                            break;
                        }
                }
                PrintMenu();
                input = GatherIntInput();
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
