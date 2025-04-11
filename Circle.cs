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
        int radius;

        public int Radius { get => radius; set => radius = value; }

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

        public override string ToString()
        {
            return $"Круг с радиусом {Radius} м.";
        }
    }
}
