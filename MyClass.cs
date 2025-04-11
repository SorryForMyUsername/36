using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal class MyClass : IMyInterface
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is implemented (реализован).");
        }
    }
}
