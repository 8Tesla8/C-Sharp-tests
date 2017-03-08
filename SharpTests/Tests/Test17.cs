using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests17
{

    //Каков будет результат при выполнении следующего фрагмента кода?

    //A

    class Test17
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
        public virtual new string Print() { return "B"; }
    }
    public class C : B
    {
        public override string Print() { return "C"; }
    }
}
