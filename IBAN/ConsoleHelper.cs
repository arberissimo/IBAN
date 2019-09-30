using System;
using System.Collections.Generic;
using System.Text;

namespace IBAN
{
    public class ConsoleHelper
    {
        public void input()
        {
            while (true)
            {
                Console.WriteLine("Geben Sie den schweizer IBAN-Code ein:");
                var iban = Console.ReadLine();

                if (iban.Length == 21)
                {
                    if (!Char.IsDigit(iban[0]) && !Char.IsDigit(iban[1]))

                    {

                        var z1 = Convert.ToInt32(iban[0]);
                        var z2 = Convert.ToInt32(iban[1]);
                        bool IBAN_true = true;

                        z1 = -55;
                        z2 = -55;

                        var ziffernfolge = Convert.ToString(z1) + "" + Convert.ToString(z2) + "00";

                        for (int i = 2; i < 21; i++)
                        {

                            if (Char.IsDigit(iban[i]))
                            {

                            }

                            else
                            {
                                IBAN_true = false;
                                break;
                            }

                        }

                        if (IBAN_true)
                        {

                            var bban = iban.Substring(4);
                            var bbanZiffern = bban + "" + ziffernfolge;

                            var pSumme = BBAN_Rechnung(bbanZiffern);
                            var pSummeStr = Convert.ToString(pSumme);

                            if (iban.Substring(2, 2).Equals(pSummeStr))

                            {

                                var bbanSummeStr = bbanZiffern.Substring(0, bbanZiffern.Length - 2) + "" + pSumme;
                                var bbanSumme = Convert.ToDecimal(bbanSummeStr);
                                var check = bbanSumme % 97;

                                if (check == 1)
                                {
                                    Console.WriteLine("IBAN Korrekt. Eingabe erfolgreich!\n");
                                    Console.ReadKey();
                                    break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Falsche Eingabe!\n");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Falsche Eingabe!\n");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Falsche Eingabe!\n");
                }
            }
        }
        public int BBAN_Rechnung(String bbanZiffern)
        {
            var bbanDecimal = Convert.ToDecimal(bbanZiffern);

            var BBAN_Modulo = bbanDecimal % 97;
            var BBAN_Summe = 98 - BBAN_Modulo;
            var pSummeStr = Convert.ToString(BBAN_Summe);

            if (pSummeStr.Length == 1)
            {
                pSummeStr = 0 + "" + pSummeStr;
            }
            BBAN_Summe = Convert.ToInt32(pSummeStr);
            return (int) BBAN_Summe;
        }
    }
}