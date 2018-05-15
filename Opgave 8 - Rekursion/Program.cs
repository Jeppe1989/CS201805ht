using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8___Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            LøkkeSomMetode(1, 10);
        }

        public static void LøkkeSomMetode(int start, int stop)
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            LøkkeSomMetode(start, stop);

        }
    }
}
