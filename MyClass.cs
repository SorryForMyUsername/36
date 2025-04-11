using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is completed");
        }

        void IMyInterfaceA.Show()
        {
            Console.WriteLine("Explicit interface Implementation. IMyInterfaceA.Show().");
        }
        void IMyInterfaceB.Show()
        {
            Console.WriteLine("Explicit interface Implementation. IMyInterfaceB.Show().");
        }
    }
}
