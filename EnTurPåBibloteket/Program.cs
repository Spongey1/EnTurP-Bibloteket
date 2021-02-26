using System;
using System.Collections.Generic;
using System.Threading;

namespace EnTurPåBibloteket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> udlånsliste = new List<string>();
            Stack<string> brugerensLån = new Stack<string>();

            Bog BogNr1 = new Bog("Twilligt Forest", DateTime.Now);
            Bog BogNr2 = new Bog("Flash", DateTime.Now);
            Bog BogNr3 = new Bog("National Geography", DateTime.Now);
            Bog BogNr4 = new Bog("Animal Kingdom", DateTime.Now);

            udlånsliste.Add(BogNr1.bogNavn);
            udlånsliste.Add(BogNr2.bogNavn);
            udlånsliste.Add(BogNr3.bogNavn);
            udlånsliste.Add(BogNr4.bogNavn);

            bogMenu();

            while (true)
            {
                Console.WriteLine("Hvad hedder bogen som du kunne tænke dig at låne?");
                string udvalgtBog = Console.ReadLine();

                if (udvalgtBog.ToLower() == "twillight forest" || udvalgtBog.ToLower() == "flash" || udvalgtBog.ToLower() == "national geography" || udvalgtBog.ToLower() == "animal kingdom")
                {
                    brugerensLån.Push(udvalgtBog);
                    udlånsliste.Remove(udvalgtBog);

                    Console.WriteLine("Kunne du tænke dig at låne flere bøger?");
                    string lånFlere = Console.ReadLine();

                    if (lånFlere.ToLower() == "ja" || lånFlere.ToLower() == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: 404");
                    continue;
                }
            }
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Dine bøger:");
            foreach (string item in brugerensLån)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void bogMenu()
        {
            Console.WriteLine("|-Bog udlåningssystem-|");
            Console.WriteLine("\r\n Hvilken bog kunne du tænke dig at låne?");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" - Twillight Forest");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" - Flash");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" - National Geography");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" - Animal Kingdom");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
