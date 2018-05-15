using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            bool res1 = Test1();
            Test2();

        }

        static bool Test1()
        {
            if(DateTime.Now.Millisecond % 2 == 0)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Test2()
        {

        }
        

    }
}
