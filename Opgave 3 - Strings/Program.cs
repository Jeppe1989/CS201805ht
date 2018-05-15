using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3___Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel ";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string del = samletNavn.Substring(7, 4);

            string[] split = samletNavn.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(split[i]);
            }

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);

            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);

            //Console.WriteLine(split);

        }
    }
}
