using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_6
{
    class Circle : IShape
    {
        string name;
        int radius;

        public int Radius
        {
            get { return radius; }
            set
            {
                if(value < 0)
                {
                    radius = 0;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    name = "Круг";
                }
            }
        }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public static Circle Input()
        {
            Console.WriteLine("Ввод нового круга.");
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Радиус: ");
            int radius = int.Parse(Console.ReadLine());
            return new Circle(radius);
        }

        public override string ToString()
        {
            return $"Круг с радиусом {Radius}.\n" +
                $"Площадь - {Area():f2}\tПериметр - {Perimeter():f2}";
        }
    }
}
