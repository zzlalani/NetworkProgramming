using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    delegate int Add(int a, int b);

    class Program
    {
        private static Add addDelegate;

        static void Main(string[] args)
        {

            addDelegate += new Add(addFunction);
            addDelegate += new Add(addFunction);
            addDelegate += new Add(addFunction2);

            int ans = -1;
            if (addDelegate != null)
                ans = addDelegate(10,20);

            Console.WriteLine(ans);
            Console.ReadLine();
        }
        
        static int addFunction(int a, int b) {

            return a + b;

        }

        static int addFunction2(int a, int b)
        {

            return a - b;

        }
    }
}
