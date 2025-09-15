using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_osa
{
    internal class funkosa3
    {
        public static string KuniMarksona(string marksona)
        {
            string fraas = "";
            do
            {
                Console.WriteLine("osta elevant ara");
                fraas = Console.ReadLine();
            } while (fraas.ToLower() != marksona.ToLower());
            return marksona;

        }


        //7 ul
        public static void GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 1; i <= ridadeArv; i++)
            {
                for (int j = 1; j <= veergudeArv; j++)
                {
                    tabel[i - 1, j - 1] = i * j;
                }
            }
            Console.WriteLine("Korrutustabel:");
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    Console.Write(tabel[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sisesta kaks arvu, et leida nende korrutustulemus (nt 7 8):");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            if (numbers.Length == 2 &&
                int.TryParse(numbers[0], out int num1) &&
                int.TryParse(numbers[1], out int num2) &&
                num1 > 0 && num1 <= ridadeArv &&
                num2 > 0 && num2 <= veergudeArv)
            {
                int tulemus = tabel[num1 - 1, num2 - 1];
                Console.WriteLine($"{num1} x {num2} = {tulemus}");
            }
            else
            {
                Console.WriteLine("Vale sisend. Palun sisesta kaks positiivset arvu vahemikus.");
            }

        
        }
        //6 ul
        public static int SuurimNeliarv(int[] arvud)
        {
            if (arvud.Length != 4 || arvud.Any(a => a < 0 || a > 9))
            {
                throw new Exception("Sisesta täpselt 4 ühekohalist arvu (0-9).");
            }
            Array.Sort(arvud);
            Array.Reverse(arvud);
            int suurimArv = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
            return suurimArv;
        }

        //5 ul
        public static bool ArvaArv()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);  // UHEST SAJANI ARVAME ARVU RANDOOOM
            int attempts = 5;

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write($"Sisesta arv ({i}/{attempts}): ");
                bool parsed = int.TryParse(Console.ReadLine(), out int guess);

                if (!parsed)
                {
                    Console.WriteLine("Palun sisesta korrektne täisarv.");
                    i--; // EI LOE KATSEKS KUI SA KIRJUTAD TAHE VOI UJUVKOMAGA ARVE
                    continue;
                }

                if (guess < number)
                {
                    Console.WriteLine("Liiga väike");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Liiga suur");
                }
                else
                {
                    Console.WriteLine("Õige!");
                    return true;  //OIGE GAME END or kusimus kas tahad veel
                }
            }

            Console.WriteLine($"Mäng läbi! Õige arv oli {number}.");
            return false;
        }

    }
}
