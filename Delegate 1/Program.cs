using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1
{
    class Program
    {
        public delegate int BeregnDelegate(int a, int b);

        static void Main(string[] args)
        {
            BeregnDelegate f = Plus;
            int res1 = Beregner(100, 1, f);
            int res = Beregner(3, 1, Minus);
            Console.WriteLine(res1);
        }


        public static int Beregner(int x, int z, BeregnDelegate funktion)
        {
            return funktion(x, z);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
