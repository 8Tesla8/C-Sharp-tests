using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests18
{
    //Что будет напечатано в результате выполнения следующего кода?

    //A:Print
    //B:Print
    //B:Print

    class Test18
    {
        public void Run()
        {
            A a = new A();
            A b = new B();
            A c = new C();

            a.Print();
            b.Print();
            c.Print();
        }
    }


    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A::Print");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B::Print");
        }
    }
    class C : B
    {
        public new void Print()
        {
            base.Print();
            Console.WriteLine("C::Print");
        }
    }
}
