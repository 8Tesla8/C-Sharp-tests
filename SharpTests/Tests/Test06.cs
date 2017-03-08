using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests6
{
    //Дан следующий код:
    class Test6
    {
        public void Run()
        {
            A obj = new B();


            //Какие из перечисленных операторов вернут true ?
            Console.WriteLine(obj is A);                    //true
            Console.WriteLine(obj is B);                    //true
            Console.WriteLine(obj.GetType() == typeof(B));  //true
            Console.WriteLine(obj.GetType() == typeof(A));  //false 
        }
    }

    class A
    { }
    class B : A
    { }
}
