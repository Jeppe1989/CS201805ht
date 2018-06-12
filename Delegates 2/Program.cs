using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            //m.Log += AppendLog;
            //m.Log += delegate (string txt) { System.IO.File.AppendAllText(@"c:/temp/log.txt" txt + "\r\n"); };
            m.Start();
            m.Stop();
          


        }

    }

    public delegate void LogDelegate(string txt);
    public class Maskine
    {
        //public LogDelegate Log { get; set; }
        public Action<string> Log { get; set; }
        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }


}
