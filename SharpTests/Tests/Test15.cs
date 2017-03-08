using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests15
{
    //Что будет выведено на экран?

    //a=1, b=1 

    class Test15
    {
        public void Run()
        {
            int a = 1, b = 2;
            Swap(a, ref b);
            Console.WriteLine("a=" + a + ", b=" + b);
            Console.ReadLine();
        }

        private static void Swap(int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
