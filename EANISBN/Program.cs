using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.Banner();
            UI.Menue();
            int select = Int32.Parse(Console.ReadLine());
            string ISBN;
            string EAN;

            switch (select)
            {
                case 1:
                    Console.WriteLine("Gib eine ISBN an, die geprüft werden soll:");
                    ISBN = Console.ReadLine();
                    Check.CheckISBN(ISBN);
                    break;

                case 2:
                    Console.WriteLine("Eine EAN wird generiert.");
                    EAN = EANGenerating.Start("DE");
                    Console.WriteLine("EAN wird in die csv geschreiben.");
                    CSVGeneration.Start("", EAN);
                    Console.WriteLine("EAN würde in output.csv gespeichert.");
                    break;

                case 3:
                    Console.WriteLine("Eine EAN wird generiert.");
                    ISBN = ISBNGenerating.Start();
                    Console.WriteLine("EAN wird in die csv geschreiben.");
                    CSVGeneration.Start("", ISBN);
                    Console.WriteLine("EAN würde in output.csv gespeichert.");
                    break;

                case 4:
                    Console.WriteLine("Land auswählen");
                    string land = Console.ReadLine();
                    CSVGeneration.Start("", EANGenerating.Start(land));
                    break;

                case 5:
                    Console.WriteLine("Die output.csv wird ausgelesen.");
                    foreach (var entry in ReadCSV.Read())
                    {
                        Console.WriteLine(entry);
                    }
                    break;

                default:
                    Environment.Exit(0x0);
                    break;
            }

            Console.ReadKey();
        }
    }
}
