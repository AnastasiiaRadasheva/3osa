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

        public static bool ArvaArv()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101); 
            int attempts = 5;

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write($"Sisesta arv ({i}/{attempts}): ");
                bool parsed = int.TryParse(Console.ReadLine(), out int guess);

                if (!parsed)
                {
                    Console.WriteLine("Palun sisesta korrektne täisarv.");
                    i--; 
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
                    return true; 
                }
            }

            Console.WriteLine($"Mäng läbi! Õige arv oli {number}.");
            return false;
        }
        public static int SuurimNeljarv(int[] arvud)
        {
            foreach (int arv in arvud)
            {
                if (arv < 0 || arv > 9)
                {
                    Console.WriteLine("Viga: Arvud peavad olema vahemikus 0 kuni 9.");
                }
            }

            Array.Sort(arvud);
            Array.Reverse(arvud);
            int tulemus = 0;
            foreach (int arv in arvud)
            {
                tulemus = tulemus * 10 + arv;
            }

            return tulemus;


        }
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv]; 
            for (int i = 1; i <= ridadeArv; i++) 
            {
                for (int j = 1; j <= veergudeArv; j++) 
                {
                    tabel[i - 1, j - 1] = i * j; 
                    Console.Write((i * j).ToString().PadLeft(4)); 
                }
                Console.WriteLine();
            }

            return tabel;
        }

        public static int OtsiTulemus(int[,] tabel, int a, int b)
        {
            return tabel[a - 1, b - 1]; 
        }

    }
}
