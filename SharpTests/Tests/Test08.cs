using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests8
{
    //Что будет напечатано в результате выполнения следующего кода?

    //Base

    class Test8
    {
        public void Run()
        {
            Console.WriteLine(new Derived().className);
        }
    }


    class Base
    {
        public String className = "Base";
    }

    class Derived : Base
    {
        private new String className = "Derived";
    }
}
