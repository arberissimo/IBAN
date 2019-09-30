using System;
using System.Collections.Generic;
using System.Text;

namespace IBAN
{
    public class ConsoleHelper
    {
        public static String input()
        {
            while(true)
            {

            int value;
            int min = 21;
            int max = 23;
            String input = Console.ReadLine();

            int.TryParse(input, out value);

            if(value < min && value > max)
            {
                Console.WriteLine("Geben Sie eine gültige Zahl ein:");
                Console.ReadLine();
                return input;
            }

            else
            {
                Console.WriteLine("\nIhre Eingabe ist korrekt.");
            }
                
            }
           
        }
        
    }
}
