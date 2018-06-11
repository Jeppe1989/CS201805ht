using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> lst1 = new List<Person>();
            //lst1.Add(new Person() { ID = 1, Navn = "M" });
            //lst1.Add(new Person() { ID = 2, Navn = "T" });
            //lst1.Add(new Person() { ID = 3, Navn = "P" });
            //foreach (var item in lst1)
            //{
            //    Console.WriteLine(item.Navn);
            //}

            Dictionary<int, Person> lst3 = new Dictionary<int, Person>();
            lst3.Add(1, new Person() { ID = 4, Navn = "A" });
            lst3.Add(2, new Person() { ID = 5, Navn = "B" });
            lst3.Add(3, new Person() { ID = 6, Navn = "C" });
            var p = lst3[1];
            Console.WriteLine(p.ID);
                

        }
    }

    class Person
    {
        public int ID { get; set; }
        public string Navn { get; set; }
    }
}
