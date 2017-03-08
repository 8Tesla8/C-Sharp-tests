using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests16
{
    //Будет ли выведена строка в результате выполнения следующего кода?

    //нет

    class Test16
    {
        public void Run()
        {
            object a = 1;
            object b = 1;

            if (b == a)
            {
                Console.WriteLine("equal");
            }
        }
    }
}
