using System;

namespace databaseclasssss
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle x = new Circle();
            x.radius = 2;
            Console.WriteLine(x.calcArea());
            Console.WriteLine(x.calcPerimeter());
            Console.WriteLine();
            Square s = new Square();
            s.sideLength = 2;
            Console.WriteLine(s.calcArea());
            Console.WriteLine(s.calcPerimeter());

        }
    }


    abstract class Shape
    {
        abstract public double calcArea();
        abstract public double calcPerimeter();
    }

    class Circle : Shape {
        public int radius { get; set; }
        private double pi = 3.14;

        override public double calcArea()
        {
            return pi * radius * radius;
        }
        override public double calcPerimeter()
        {
            return 2 * pi * radius;
        }
    }

    class Square : Shape
    {
        public int sideLength { get; set; }

        public override double calcArea()
        {
            return sideLength * sideLength;
        }

        public override double calcPerimeter()
        {
            return 4 * sideLength;
        }
    }

}
