using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests19
{
    //Какое значение будет занесено в переменную b?

    //2

    class Test19
    {
        public void Run()
        {
            Func<int> d;
            d = () => 0;
            d += () => 1;
            d += () => 2;
            int b = d();

            Console.WriteLine(b);
        }
    }
}
