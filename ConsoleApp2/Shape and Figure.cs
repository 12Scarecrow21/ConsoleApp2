using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     abstract class Shape
     {
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(double x1, double y1, double x2, double y2)
        {
            Width = Math.Abs(x2 - x1);
            Height = Math.Abs(y2 - y1);
        }

        public override double Area()
        {
            return Width*Height;
        }
        public override double Perimeter()
        {
            return 2*(Height+Width);
        }
        public bool Square() => Height == Width; 
    }
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sidea, double sideb, double sidec) 
        {
            SideA = sidea;
            SideB = sideb;
            SideC = sidec;
        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            SideA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            SideB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            SideC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        }
        public override double Area()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double Perimeter()
        {
            return  SideA + SideB + SideC;
        }
        public bool Equilateral() => SideA == SideB && SideB == SideC;
    }
    class Circle : Shape
    {
        public double Radius{get; set;}
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle(double centerX, double centerY, double pointX, double pointY)// pointX/pointY точки на окружности 
        {
            Radius = Math.Sqrt(Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2));        
        }
        public override double Area() 
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
