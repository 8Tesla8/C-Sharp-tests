using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests13
{
    //Что выведет на экран код?

    //A.Go()
    //C.Go()
    //A.Go()
    //С.Go()

    class Test13
    {
        public void Run()
        {
            B b1 = new B();
            C c1 = new C();
            B b2 = c1;
            b1.Go();
            c1.Go();
            b2.Go();
            ((I)b2).Go();
        }
    }

    
    public interface I
    {
        void Go();
    }

    public class A : I
    {
        public void Go()
        {
            Console.WriteLine("A.Go()");
        }
    }

    class B : A { }

    class C : B, I
    {
        public new void Go()
        {
            Console.WriteLine("C.Go()");
        }
    }
}
