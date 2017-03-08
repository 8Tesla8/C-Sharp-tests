using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests14
{
    //Каков будет результат при выполнении следующего фрагмента кода?

    //B

    class Test14
    {
        public void Run()
        {
            A ac = new C();
            Console.WriteLine(ac.Print());
        }
    }


    public abstract class A
    {
        public virtual string Print() { return "A"; }
    }

    public class B : A
    {
        public override string Print() { return "B"; }
    }

    public class C : B
    {
        public new string Print() { return "C"; }
    }
}
