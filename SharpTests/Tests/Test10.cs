using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests10
{
    //Что будет выведено на экран в результате работы программы?

    class Test10
    {
        public void Run()
        {
            A a = new A();
            B b = new B();

            Console.WriteLine(a is A);  //true
            Console.WriteLine(a is B);  //false
            Console.WriteLine(b is A);  //true
            Console.WriteLine(b is B);  //true
        }
    }
    

    class A { }
    class B : A { }
}
