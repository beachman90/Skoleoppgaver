using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square smallSquare = new Square();
            smallSquare = int.Parse(Console.ReadLine())
            Console.WriteLine(smallSquare.CalculateArea());
            Console.WriteLine(smallSquare.CalculateOmkrets());

            Circle circle = new();
            circle.radius = 5;
            Console.WriteLine("\n" + circle.CalculateOmkrets());
            Console.WriteLine(circle.CalculateArea());

            Triangle triangle = new();
            triangle.length = 10;
            Console.WriteLine("\n" + triangle.CalculateOmkrets());
            Console.WriteLine(triangle.CalculateArea());

            Rectangle rectangle = new();
            rectangle.length = 15;
            rectangle.height = 17;
            Console.WriteLine("\n" + rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculateOmkrets());

        }
    }

    class Square
    {
        private int _length;

        public int GetLength()
        {
            return _length;
        }

        public void SetLength(int length)
        {
            if ()
            {
            _length = length;
            }

        }
        public int CalculateArea()
        {
            int area = _length * _length;
            return area;
        }

        public int CalculateOmkrets()
        {
            int omkrets = _length * 4;
            return omkrets;
        }
    }

    class Circle
    {
        public double pi = 3.14;
        public double radius = 5;

        public double CalculateOmkrets()
        {
            double omkrets = 2 * pi * radius;
            return omkrets;
        }

        public double CalculateArea()
        {
            double area = pi*(radius*radius);
            return area;
        }

        

    }

    class Triangle
    {
        public double length;

        public double CalculateOmkrets()
        {
            double omkrets = length * 3;
            return omkrets;
        }

        public double CalculateArea()
        {
            double area = 20;
            return area;
        }
    }

    class Rectangle
    {
        public int length;
        public int height;

        public int CalculateOmkrets()
        {
            int omkrets = (length*2) + (height*2);
            return omkrets;
        }

        public int CalculateArea()
        {
            int area = height * length;
            return area;
        }
    }

}