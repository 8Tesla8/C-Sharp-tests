using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests25
{
    //В каких строках содержатся ошибки компиляции?

    //1 структура не может наследоватся от класса
    //2 в структуре инициализацию переменной(поля) можно присвоить только в конструкторе
    //3 в структуре нельзя создать конструктор по умолчанию, 
    //он создается неявным образом и всем полям ставит значение по умолчанию 

    //class A { }
    //interface Inner { }

    //struct S : A, Inner //1
    //{
    //    int num = 10; //2
    //    public S() //3
    //    { }

    //    static S() //4
    //    { }
    //}

    //class Test25
    //{
    //    public void Run()
    //    {
    //        S obj = new S(); //5
    //    }
    //}
}
