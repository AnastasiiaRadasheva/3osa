using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_osa
{
    internal class Isik
    {
        public string eesnimi;
        public string perenimi;
        public int synniaasta;

        public Isik() { }
        public Isik(string eesnimi, string perenimi)
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
        }
        public void andmed()
        {
            Console.WriteLine($"isiku andmed: {eesnimi} {perenimi} , sundinud: {synniaasta}");

        }
    }
}
