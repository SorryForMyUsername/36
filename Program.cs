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
            Console.WriteLine("***Изучение интерфейсов. Пример - 4***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.Show();
            IMyInterfaceA interA = myClassOb;
            interA.Show();
            IMyInterfaceB interB = myClassOb;
            interB.Show();
            Console.Read();
        }
    }
}
