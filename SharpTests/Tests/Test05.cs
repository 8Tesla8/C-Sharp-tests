using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests5
{
    //что произойдет в данном коде 

    //This is B
    //new перекрывает но не делает override

    class Test5
    {
        public void Run()
        {
            var a = new A();
            a.Print();
        }
    }

    abstract class B
    {
        public virtual void Print()
        {
            Console.WriteLine("This is B");
        }
    }

    class A : B
    {
        private new void Print()
        {
            Console.WriteLine("This is A");
        }
    }
}
