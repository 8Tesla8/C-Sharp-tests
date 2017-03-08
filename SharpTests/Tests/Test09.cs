using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests9
{
    //Что будет напечатано в результате выполнения следующего кода?

    //B.SomeMethod

    class Test9
    {
        public void Run()
        {
            var c = new C();
            c.CallSomeMethod();
        }
    }

    class A
    {
        public void SomeMethod()
        {
            Console.WriteLine("A.SomeMethod");
        }
    }

    internal class B : A
    {
        new protected void SomeMethod()
        {
            Console.WriteLine("B.SomeMethod");
        }
    }

    internal class C : B
    {
        public void CallSomeMethod()
        {
            SomeMethod();
        }
    }
}
