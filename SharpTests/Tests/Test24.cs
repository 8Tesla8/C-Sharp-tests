using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests24
{
    //В каких строках содержатся ошибки компиляции?

    //3 privet set
    //6 event можно вызвать только внутри класса, снаружи нельзя
    
    //class Test24
    //{
    //    public void Run()
    //    {
    //        Foo foo = new Foo();
    //        foo.A += () => { }; // 1
    //        foo.A(); // 2
    //        foo.B += () => { }; // 3
    //        foo.B(); // 4
    //        foo.C += () => { }; // 5
    //        foo.C(); // 6
    //    }
    //}

    //public class Foo
    //{
    //    public Action A;
    //    public Action B { get; private set; }
    //    public event Action C;
    //}
}
