using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal abstract class MyClass : IMyInterface
    {
        public void Show1()
        {
            Console.WriteLine("MyClass.Show1() is implemented (реализован).");
        }
        public abstract void Show2();
    }
}
