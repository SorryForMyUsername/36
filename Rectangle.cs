using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_6
{
    class Rectangle : IShape
    {
        string name;
        int side1;
        int side2;

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

        public Rectangle(int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double Area()
        {
            return Side1 * Side2;
        }

        public double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }

        public static Rectangle Input()
        {
            Console.WriteLine("Ввод нового прямоугольника.");
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Первая сторона: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Третья сторона: ");
            return new Rectangle(side1, side2);
        }

        public override string ToString()
        {
            return $"Прямоугольник со сторонами {Side1} и {Side2}\n" +
                $"Площадь - {Area():f2}\tПериметр - {Perimeter():f2}";
        }
    }
}
