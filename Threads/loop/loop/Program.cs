using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t = new Thread(new ThreadStart(GO));
            t.Start();

            Thread th = new Thread(new ParameterizedThreadStart(GOZ));
            th.Start(true);

            while (true)
            {
                Console.WriteLine("X");
            }

            
        }

        static void GO()
        {
            while (true) 
            {
                Console.WriteLine("            Y");
            }
        }

        static void GOZ(object obj)
        {
            while (true)
            {
                Console.WriteLine("                        Z");
            }
        }

    }
}
