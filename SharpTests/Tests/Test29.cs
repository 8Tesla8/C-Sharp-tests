using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests29
{
    //Что выведет на экран код?

    //Object 2
    //Hello 

    class Test29
    {
        public void Run()
        {
            A obj1 = new A("Object 1");
            A obj2 = new A("Object 2");

            obj1 = obj2;
            obj1.str = "Hello";

            Console.WriteLine(obj2.str);

            В obj3 = new В("Object 3");
            В obj4 = new В("Object 4");

            obj3 = obj4;
            obj3.str = "Hello";

            Console.WriteLine(obj4.str);
        }
    }

    

    struct A
    {
        public string str;
        public A(string s) { str = s; }
    }

    class В
    {
        public string str;
        public В(string s) { str = s; }
    }
}
