using System;

namespace IBAN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().Run();
        }
        public void Run()
        {
            Console.WriteLine("IBAN-Check");

            Console.WriteLine("\nWählen Sie bitte Ihr gewünsten Bereich: ");
            Console.WriteLine("\n[a] IBAN-Nummer prüfen");
            Console.WriteLine("[b] Was ist IBAN?");

            var hauptmenu = Console.ReadLine();

            switch(hauptmenu)
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine("\nGeben Sie Ihre IBAN-Nummer an:");
                    Console.ReadLine();
                    break;

                case "b":
                    Console.Clear();
                    Console.WriteLine("Die IBAN ist die Nummer, die Sie auf Ihrer Bankkarte finden.");
                    Console.WriteLine("Beispiel: CH31 8123 9000 0012 4568 9");
                    Console.Clear();
                    return;
            }

            ConsoleHelper.input();
        }
     }
  }
