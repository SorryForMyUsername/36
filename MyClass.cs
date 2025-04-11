using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void ShowA()
        {
            Console.WriteLine("MyClass.ShowA() is completed.");
        }
        public void ShowB()
        {
            Console.WriteLine("MyClass.ShowB() is completed.");
        }
    }
}
