using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_6
{
    class Triangle : IShape
    {
        string name;
        int side1;
        int side2;
        int side3;

        public int Side1
        {
            get { return side1; }
            set
            {
                if (value < 0)
                {
                    side1 = 0;
                }
            }
        }
        public int Side2
        {
            get { return side2; }
            set
            {
                if (value < 0)
                {
                    side2 = 0;
                }
            }
        }
        public int Side3
        {
            get { return side3; }
            set
            {
                if (value < 0)
                {
                    side3 = 0;
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

        public Triangle(string name, int side1, int side2, int side3)
        {
            Name = name;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Area()
        {
            double p = Perimeter() / 2.0;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p * side3));
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public static Triangle Input()
        {
            Console.WriteLine("Ввод нового треугольника.");
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Первая сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Третья сторона: ");
            int side3 = int.Parse(Console.ReadLine());
            return new Triangle(name, side1, side2, side3);
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами {Side1}, {Side2} и {Side3}\n" +
                $"Площадь - {Area():f2}\tПериметр - {Perimeter():f2}";
        }
    }
}
