using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_6
{
    class Rectangle : IShape
    {
        int side1;
        int side2;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }

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

        public override string ToString()
        {
            return $"Прямоугольник со сторонами {Side1} м и {Side2} м";
        }
    }
}
