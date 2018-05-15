using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdave_1___Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal = heltal++;
            heltal = heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("dMy"));
            Console.WriteLine(dato.ToLongDateString());


            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);
     
        }

        public enum FilTyper
        {
            csv,
            pdf,
            txt
        }

        struct Person
        {
            public int Id;
            public string Navn;
        }
    }
}
