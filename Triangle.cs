using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_6
{
    class Triangle : IShape
    {
        int side1;
        int side2;
        int side3;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public Triangle(int side1, int side2, int side3)
        {
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

        public override string ToString()
        {
            return $"Треугольник со сторонами {Side1} м, {Side2} м и {Side3} м";
        }
    }
}
