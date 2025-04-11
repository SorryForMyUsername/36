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
            Console.WriteLine("***Изучение интерфейсов. Пример - 3***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.ShowA();
            myClassOb.ShowB();
            Console.Read();
        }
    }
}
