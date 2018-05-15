using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9___Simpel_klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "and";
            p1.Fornavn = "anders";
            p1.Fødselsår = 1989;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());
                       

        }
    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string efternavn, string fornavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();

        }
    }
}
