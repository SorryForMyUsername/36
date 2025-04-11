using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Изучение интерфейсов. Пример - 2***\n");
            MyClass myOb = new ChildClass();
            myOb.Show1();
            myOb.Show2();
            Console.Read();
        }
    }
}
