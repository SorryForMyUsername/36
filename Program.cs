using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            while(true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить треугольник\n" +
                    "2. Добавить прямоугольник\n" +
                    "3. Добавить круг\n" +
                    "4. Вывести все фигуры\n" +
                    "5. Выход из программы\n");

                int choice = Console.ReadKey(true).KeyChar - 48;

                switch (choice)
                {
                    case 1:
                        shapes.Add(Triangle.Input());
                        break;
                    case 2:
                        shapes.Add(Rectangle.Input());
                        break;
                    case 3:
                        shapes.Add(Circle.Input());
                        break;
                    case 4:
                        OutputShapes(shapes);
                        break;
                    case 5: return;
                }

                Console.WriteLine();
            }
        }

        static void OutputShapes(List<IShape> shapes)
        {
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"{shape}\n");
            }
        }
    }
}
