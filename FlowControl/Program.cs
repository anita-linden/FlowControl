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
            Console.WriteLine("\nVälkommen till huvudmenyn. Vänligen ange numret för vald funktion.\n");
            Console.WriteLine("1 - Biljett system");
            Console.WriteLine("0 - Avsluta program");
            Console.WriteLine("\n");
        }

        private static void BuyTickets()
        {
            Console.WriteLine("\nVälkommen till biografens biljettsystem!");
            Console.WriteLine("Är ni ett sällskap?\n1 för ja. 2 för nej.");
            string selection = Console.ReadLine();


            if (selection == "1")
            {
                Console.WriteLine("\nHur många är det i sällskapet?");
                int customers = ReadInteger();
                int sum = 0;
                for (int i = 0; i < customers; i++)
                {
                    Console.WriteLine("\nHur gammal är denna besökare?");
                    int age = ReadInteger();
                    sum += GetTicket(age).Price;
                }
                Console.WriteLine($"\nAntal besökare: {customers}");
                Console.WriteLine($"Totalt kostnad: {sum} kr");
            }
            else if (selection == "2")
            {
                Console.WriteLine("\nHur gammal är besökaren?");
                int age = ReadInteger();

                Ticket t = GetTicket(age);

                Console.WriteLine($"\n{t.Type}: {t.Price} kr");
            }
            else
                Console.WriteLine("\nOgiltigt kommando");
            
        }

        private static int ReadInteger()
        {
            int input;

            while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
                Console.WriteLine("Snälla skriv en giltig siffra");
            return input;
        }

        public static Ticket GetTicket(int age)
        {
            Ticket t = new Ticket();
            if (age < 20)
            {
                t.Type = "Ungdomspris";
                t.Price = 80;
            } 
            else if (age > 64)
            {
                t.Type = "Pensionärspris";
                t.Price = 90;
            }
            else
            {
                t.Type = "Standardpris";
                t.Price = 120;
            }

            return t;
        }

    }
}
