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
            Console.WriteLine("***Изучение интерфейсов. Пример - 5***\n");
            Console.WriteLine("***Concept of multiple inheritance through interface***\n");
            MyClass myClassOb = new MyClass();
            InterfaceA obA = myClassOb;
            obA.ShowInterfaceA();
            InterfaceB obB = myClassOb;
            obB.ShowInterfaceB();
            InterfaceC obC = myClassOb;
            obC.ShowInterfaceC();
            Console.Read();
        }
    }
}
