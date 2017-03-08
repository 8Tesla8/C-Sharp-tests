using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests
{
    //Скомпилируется ли следующий код?

    //нет
    //static методы нельзя вызывать от именни обьекта только от имени класса - A.Show()

    //class Test30
    //{
    //    public void Run()
    //    {
    //        A obj = new A();
    //        obj.Show();
    //    }
    //}


    //class A
    //{
    //    const int a = 10;
    //    static int b = 20;
    //    public static void Show()
    //    {
    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //    }
    //}
}
