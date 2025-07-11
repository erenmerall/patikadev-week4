using System;

namespace GeometricShapes
{
    // Base class
    class BaseClass
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public BaseClass(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Sanal (virtual) alan hesaplama metodu
        public virtual double CalculateArea()
        {
            return Width * Height;
        }
    }

    // kare sınıfı
    class Square : BaseClass
    {
        public Square(double side) : base(side, side) { }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Dikdörtgen sınıfı
    class Rectangle : BaseClass
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Dik üçgen sınıfı

    class RightTriangle : BaseClass
    {
        public RightTriangle(double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            return (Width * Height) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass square = new Square(5);
            BaseClass rectangle = new Rectangle(4, 6);
            BaseClass rightTriangle = new RightTriangle(4, 6);

            Console.WriteLine("Kare Alanı: " + square.CalculateArea());
            Console.WriteLine("Dikdmen Alanı: " + rectangle.CalculateArea());
            Console.WriteLine("Dik Üçgen Alanı: " + rightTriangle.CalculateArea());

            Console.ReadLine();
        }
    }
}
