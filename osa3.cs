using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_osa
{
    internal class osa3
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //3. osa massiivid, list, kordused
            List<string> nimed = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} nimi: ");
                nimed.Add(Console.ReadLine());
            }

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }

            int[] arvud = new int[10];
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j + 1);
                arvud[j] = rnd.Next(1, 101);
                j++;
            }
            foreach (int arv in arvud)
            {
                Console.WriteLine(arv);
            }

            List<Isik> isikud = new List<Isik>();
            j = 0;
            do
            {
                Console.WriteLine(j + 1);
                Isik isik = new Isik();
                Console.WriteLine("eesnimi: ");
                isik.eesnimi = Console.ReadLine();
                Console.WriteLine("perenimi: ");
                isik.perenimi = Console.ReadLine();

                isikud.Add(isik);

                j++;
            }
            while (j < 10);
            isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            Console.WriteLine($"kokku on {isikud.Count()} isikud");

            foreach (Isik isik in isikud)
            {
                isik.andmed();
            }
            Console.WriteLine($"kolmandal kohal on {isikud[2].eesnimi} isik");

            //1 
            ArvuTöötlus at = new ArvuTöötlus();
            at.GenereeriRuudud(-100, 100);

            //13
            {
                Random rndo = new Random();
                List<int> arv = new List<int>();

                // Genereerime 20 juhuslikku täisarvu 0-100
                for (int i = 0; i < 20; i++)
                {
                    arv.Add(rndo.Next(0, 101));
                }

                // Paarisarvude summa - for tsükkel
                int paarisSumma = 0;
                for (int i = 0; i < arv.Count; i++)
                {
                    if (arv[i] % 2 == 0)
                    {
                        paarisSumma = paarisSumma + arv[i];
                    }
                }

                // Paaritute keskmine - foreach tsükkel
                int paarituSumma = 0;
                int paarituArv = 0;
                foreach (int arvv in arv)
                {
                    if (arvv % 2 != 0)
                    {
                        paarituSumma = paarituSumma + arvv;
                        paarituArv = paarituArv + 1;
                    }
                }

                double paarituKeskmine = 0;
                if (paarituArv > 0)
                {
                    paarituKeskmine = (double)paarituSumma / paarituArv;
                }

                // Suuremad kui 50 - while tsükkel
                int index = 0;
                int suuremad = 0;
                while (index < arv.Count)
                {
                    if (arv[index] > 50)
                    {
                        suuremad = suuremad + 1;
                    }
                    index = index + 1;
                }

                // Väljasta tulemused
                Console.WriteLine("Arvud: ");
                for (int i = 0; i < arv.Count; i++)
                {
                    Console.Write(arv[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"Paarisarvude summa:  {paarisSumma}");
                Console.WriteLine($"Paaritute keskmine: {paarituKeskmine}");
                Console.WriteLine($"Arvud suuremad kui 50: {suuremad}");
            }

            //12
            {
                int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

                int suurim = numbrid[0];
                int suurimaIndex = 0;

                for (int i = 1; i < numbrid.Length; i++)
                {
                    if (numbrid[i] > suurim)
                    {
                        suurim = numbrid[i];
                        suurimaIndex = i;
                    }
                }

                Console.WriteLine($"Suurim arv on: {suurim}");
                Console.WriteLine($"Suurima arvu indeks on: {suurimaIndex}");
            }

            //2
            {
                {
                    double[] arvud2 = Tekstist_arvud();

                    var tulemus = AnalüüsiArve(arvud2);

                    Console.WriteLine($"Summa: {tulemus.Item1:F2}");
                    Console.WriteLine($"Keskmine: {tulemus.Item2:F2}");
                    Console.WriteLine($"Korrutis: {tulemus.Item3:F2}");
                }

                static double[] Tekstist_arvud()
                {
                    Console.WriteLine("Sisesta arvud (tühikuga eraldatud):");
                    return Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                }

                static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
                {
                    double summa = 0, korrutis = 1;
                    foreach (var arv in arvud)
                    {
                        summa += arv;
                        korrutis *= arv;
                    }
                    double keskmine = arvud.Length > 0 ? summa / arvud.Length : 0;
                    return Tuple.Create(summa, keskmine, korrutis);
                }
            }
            ////3
            //static Tuple<int, double, Inimene, Inimene>
            //Statistika(List<Inimene> inimesed)
            //{
            //    int summa = 0;
            //    Inimene vanim = inimesed[0];
            //    Inimene noorim = inimesed[0];

            //    foreach (var i in inimesed)
            //    {
            //        summa += i.vanus;
            //        if (i.vanus > vanim.vanus) vanim = i;
            //        if (i.vanus < noorim.vanus) noorim = i;
            //    }

            //    double keskmine = (double)summa / inimesed.Count;
            //    return Tuple.Create(summa, keskmine, vanim, noorim);
            //}
            //{
            //    List<Inimene> inimesed = new List<Inimene>();

            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.Write("Nimi: ");
            //        string nimi = Console.ReadLine();
            //        Console.Write("Vanus: ");
            //        int vanus = int.Parse(Console.ReadLine());

            //        inimesed.Add(new Inimene { nimi = nimi, vanus = vanus });
            //    }

            //    var stat = Statistika(inimesed);

            //    Console.WriteLine($"Summa: {stat.Item1}");
            //    Console.WriteLine($"Keskmine: {stat.Item2}");
            //    Console.WriteLine($"Vanim: {stat.Item3.nimi} ({stat.Item3.vanus})");
            //    Console.WriteLine($"Noorim: {stat.Item4.nimi} ({stat.Item4.vanus})");
            //}
            //4
            Console.WriteLine("sisesta marksona: ");
            string marksona = Console.ReadLine();
            string tulemus66 = funkosa3.KuniMarksona(marksona);
            Console.WriteLine(tulemus66);

            ////6
            //Console.WriteLine(" #6 Sisesta  arv:");
            //int[] arvud = new int[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Sisesta {i + 1}. arv (0-9):");
            //    arvud[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(funk.SuurimNeliarv(arvud));
            ////7
            //Console.WriteLine(" #7 Sisesta ridade arv:");
            //int ridadeArv = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta veergude arv:");
            //int veergudeArv = int.Parse(Console.ReadLine());
            //funk.GenereeriKorrutustabel(ridadeArv, veergudeArv);
            //5
            while (true)
            {
                funk.ArvaArv();

                Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
                string vastus = Console.ReadLine().ToLower();

                if (vastus != "jah")
                {
                    Console.WriteLine("Mäng läbi. Aitäh mängimast!");
                    break;
                }
            }

        }
    }
