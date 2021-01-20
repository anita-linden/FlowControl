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
                    case "1":
                        BuyTickets();
                        break;
                    case "0":
                        Console.WriteLine("Good bye!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Undefined input.\n");
                        break;
                }
            }


            
        }
        private static void PrintInstructions()
        {
            Console.WriteLine("Välkommen till huvudmenyn. Vänligen ange numret för vald funktion.\n");
            Console.WriteLine("1 - Biljett system");
            Console.WriteLine("0 - Avsluta program");
            Console.WriteLine("\n");
        }

        private static void BuyTickets()
        {
            Console.WriteLine("Hur gammal är kunden?");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Please type a number for age");

            if (age < 20)
                Console.WriteLine("Ungdomspris: 80 kr");
            else if (age > 64)
                Console.WriteLine("Pensionärspris: 90 kr");
            else
                Console.WriteLine("Standardpris: 120 kr");
        }

    }
}
