using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests1
{
    //Что будет выведено на экран?

    //у класса по умолчанию модификатор доступа internal
        
    class A
    {
        static A()
        {
            Console.WriteLine("Static Hello from A");
        }

        public A()
        {
            Console.WriteLine("Hello from A");
        }
    }

    class B
    {
        public static string x = "Hello";

        static B()
        {
            Console.WriteLine("Static Hello from B");
        }

        public B()
        {
            Console.WriteLine("Hello from B");
        }
    }

    class Test1
    {
        public void Run()
        {
            A a = new A();
            Console.WriteLine(B.x);
        }
    }
    //Static Hello from A Hello from A Static Hello from B Hello

}
