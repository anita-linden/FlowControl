using System;
using System.Collections.Generic;

namespace FlowControl
{
    /// <summary>
    /// Ett program för att test switch, for och if satser
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while(running)
            {
                PrintInstructions();

                switch (Console.ReadLine())
                {
                    case "1":
                        BuyTickets();
                        break;
                    case "2":
                        RepeatTen();
                        break;
                    case "3":
                        ThirdWord();
                        break;
                    case "0":
                        Console.WriteLine("\nHej då!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\nUndefined input.\n");
                        break;
                }
            }


            
        }

        /// <instruktioner>
        /// Eventuellt en onödig funktion, men det här hjälper mig att hålla reda på startskärmsinstruktionerna och dess format.
        /// Kan enkelt lägga till eller ta bort rader som beskriver program funktioner.
        /// </instruktioner>
        private static void PrintInstructions()
        {
            Console.WriteLine("\nVälkommen till huvudmenyn. Vänligen ange numret för vald funktion.\n");
            Console.WriteLine("1 - Biljett system");
            Console.WriteLine("2 - Upprepa 10 gånger");
            Console.WriteLine("3 - Det tredje ordet");
            Console.WriteLine("0 - Avsluta program");
            Console.WriteLine("\n");
        }

        /// <biljettköp>
        /// Ett kvitteringssystem? Skriver ut biljettyp och pris.
        /// Använder sig av metoderna ReadInteger() och GetTicket() för att hålla koden modulär.
        /// </biljettköp>
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

        /// <readint>
        /// Eftersom jag vill felhantera när användaren inte skriver giltiga siffror i biljettprogrammet,
        /// så har jag skrivit en metod som hanterar det och ber användaren upprepa tills en giltig siffra
        /// angivits.
        /// </readint>
        private static int ReadInteger()
        {
            int input;

            while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
                Console.WriteLine("Snälla skriv en giltig siffra");
            return input;
        }

        /// <getticket>
        /// Hämtar korrekt biljettinformation genom en if sats. Huvudmetoden kan sedan skriva ut detta i rätt format.
        /// </getticket>
        public static Ticket GetTicket(int age)
        {
            string type = "";
            int price = 0;

            if (age < 5 || age > 100)
            {
                type = "Gratis";
                price = 0;
            }
            else if(age < 20)
            {
                type = "Ungdomspris";
                price = 80;
            } 
            else if (age > 64)
            {
                type = "Pensionärspris";
                price = 90;
            }
            else
            {
                type = "Standardpris";
                price = 120;
            }

            return new Ticket(type, price);
        }

        /// <repeatten>
        /// Inte mer komplicerat än att ha en 10 steg lång for loop som använder Console.Write för att upprepa en sträng 10 gånger
        /// Numrerad och separerared med komma
        /// </repeatten>
        private static void RepeatTen()
        {
            Console.WriteLine("\nAnge en text för programmet att upprepa:");
            string input = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input}");
                if (i < 9)
                    Console.Write(", ");
            }
        }

        /// <thirdword>
        /// Hittar det tredje ordet. Vi upprepar begäran tills användaren har skrivit en sträng med 2 mellanslag genom att kolla
        /// längden på input.
        /// </thirdword>
        private static void ThirdWord()
        {
            Console.WriteLine("\nSkriv en mening med mellanslag så får du tillbaks det tredje ordet:");
            var input = Console.ReadLine().Split();
            string word = "";
            int foundWords = 0;

            //hitta tredje ordet medans mellanslag ignoreras
            while (foundWords < 3)
            {
                foundWords = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != string.Empty)
                    {
                        foundWords++;
                        if (foundWords == 3)
                        {
                            word = input[i];
                            break;
                        }
                    }
                }

                if (foundWords < 3)
                {
                    Console.WriteLine("\nSkriv minst tre ord");
                    input = Console.ReadLine().Split();
                }
                
            }

            Console.WriteLine($"\n{word}");
        }

    }
}
