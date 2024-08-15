using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                Console.WriteLine("Выберите фигуру: 1-Прямоугольник, 2-Треугольник, 3-Круг, 0-Выход");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;

                Shape shape;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1 - Введите ширину и высоту, 2 - Введите координаты противоположных углов");
                        int rectChoice = int.Parse(Console.ReadLine());

                        if (rectChoice == 1)
                        {
                            Console.Write("Введите ширину: ");
                            double width = double.Parse(Console.ReadLine());
                            Console.Write("Введите высоту: ");
                            double height = double.Parse(Console.ReadLine());
                            shape = new Rectangle(width, height);
                        }
                        else
                        {
                            Console.Write("Введите координаты первой точки (x1 y1): ");
                            double x1 = double.Parse(Console.ReadLine());
                            double y1 = double.Parse(Console.ReadLine());
                            Console.Write("Введите координаты второй точки (x2 y2): ");
                            double x2 = double.Parse(Console.ReadLine());
                            double y2 = double.Parse(Console.ReadLine());
                            shape = new Rectangle(x1, y1, x2, y2);
                        }
                        break;

                    case 2:
                        Console.WriteLine("1 - Введите длины сторон, 2 - Введите координаты вершин");
                        int triChoice = int.Parse(Console.ReadLine());

                        if (triChoice == 1)
                        {
                            Console.Write("Введите сторону A: ");
                            double sideA = double.Parse(Console.ReadLine());
                            Console.Write("Введите сторону B: ");
                            double sideB = double.Parse(Console.ReadLine());
                            Console.Write("Введите сторону C: ");
                            double sideC = double.Parse(Console.ReadLine());
                            shape = new Triangle(sideA, sideB, sideC);
                        }
                        else
                        {
                            Console.Write("Введите координаты первой точки (x1 y1): ");
                            double x1 = double.Parse(Console.ReadLine());
                            double y1 = double.Parse(Console.ReadLine());
                            Console.Write("Введите координаты второй точки (x2 y2): ");
                            double x2 = double.Parse(Console.ReadLine());
                            double y2 = double.Parse(Console.ReadLine());
                            Console.Write("Введите координаты третьей точки (x3 y3): ");
                            double x3 = double.Parse(Console.ReadLine());
                            double y3 = double.Parse(Console.ReadLine());
                            shape = new Triangle(x1, y1, x2, y2, x3, y3);
                        }
                        break;

                    case 3:
                        Console.WriteLine("1 - Введите радиус, 2 - Введите координаты центра и точки на окружности");
                        int circChoice = int.Parse(Console.ReadLine());

                        if (circChoice == 1)
                        {
                            Console.Write("Введите радиус: ");
                            double radius = double.Parse(Console.ReadLine());
                            shape = new Circle(radius);
                        }
                        else
                        {
                            Console.Write("Введите координаты центра (x y): ");
                            double centerX = double.Parse(Console.ReadLine());
                            double centerY = double.Parse(Console.ReadLine());
                            Console.Write("Введите координаты точки на окружности (x y): ");
                            double pointX = double.Parse(Console.ReadLine());
                            double pointY = double.Parse(Console.ReadLine());
                            shape = new Circle(centerX, centerY, pointX, pointY);
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        continue;
                }

                shapes.Add(shape);

                Console.WriteLine($"Площадь: {shape.Area()}");
                Console.WriteLine($"Периметр: {shape.Perimeter()}");

                if (shape is Rectangle rect)
                {
                    Console.WriteLine(rect.Square() ? "Прямоугольник является квадратом." : "Прямоугольник не является квадратом.");
                }
                else if (shape is Triangle tri)
                {
                    Console.WriteLine(tri.Equilateral() ? "Треугольник является равносторонним." : "Треугольник не является равносторонним.");
                }
            }
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }
            Console.WriteLine($"Суммарная площадь всех фигур: {totalArea}");
        }
    }
}
