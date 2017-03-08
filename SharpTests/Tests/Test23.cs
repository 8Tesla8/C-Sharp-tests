using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests23
{
    //Что напечатает следующий код?

    //in Method1 
    //in Method2

    class Test23
    {
        public void Run()
        {
            if (Method1() & Method2())
            {
                Console.WriteLine("inside if");
            }
        }

        bool Method1()
        {
            Console.WriteLine("in Method1");
            return false;
        }
        bool Method2()
        {
            Console.WriteLine("in Method2");
            return true;
        }
    }
}
