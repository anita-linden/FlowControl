using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while(running)
            {
                PrintInstructions();

                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Good bye!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Undefined input.\n");
                        break;
                }
            }

            static void PrintInstructions()
            {
                Console.WriteLine("Welcome to the main menu. Please input a number to access different operations.\n");
                Console.WriteLine("0 - Exits the program");
                Console.WriteLine("\n");
            }
        }
    }
}
