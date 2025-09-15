using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_osa
{
    internal class ArvuTöötlus
    {
        public int[] GenereeriRuudud(int min, int max)
        {
            Random rand = new Random();
            int N = rand.Next(-100, 101);
            int M = rand.Next(-100, 101);
            int start = int.Min(N, M);
            int end = int.Max(N, M);

            int length = end - start + 1;
            int[] ruudud = new int[length];

            for (int i = 0; i < length; i++)
            {
                int value = start + i;
                ruudud[i] = value * value;
            }
            for (int i = 0; i < length; i++)
            {
                int value = start + i;
                Console.WriteLine($"{value} → {ruudud[i]}");
            }

            return ruudud;
        }

    }
}
