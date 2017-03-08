using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests27
{
    //Скомпилируется ли следующий код?

    //нет 
    //у static конструктора не может быть параметров он вызывается неявным образом
    //this не может быть в static методе или конструкторе 

    //class Test27
    //{
    //    private static int i;

    //    static Test27(int a)
    //    {
    //        this.i = a;
    //        Console.WriteLine("In static constructor");
    //    }
    //    public void Run()
    //    { }
    //}
}
