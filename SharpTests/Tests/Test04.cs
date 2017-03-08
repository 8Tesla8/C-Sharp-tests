using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTests.Tests4
{
    //что произойдет при выполнении данного кода

    //The Bus constructor invoked.
    //The Drive method invoked.


    class Test4
    {
        public void Run()
        {
            Bus.Drive();
        }
    }

    public class Car
    {
        public Car()
        {
            System.Console.WriteLine("The Car constructor invoked.");
        }
    }

    public class Bus : Car
    {
        static Bus()
        {
            System.Console.WriteLine("The Bus constructor invoked.");
        }

        public static void Drive()
        {
            System.Console.WriteLine("The Drive method invoked.");
        }
    }
}