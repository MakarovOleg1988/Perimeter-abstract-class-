using System;

namespace Perimeter_abstract_class_
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure _rectangle = new Rectangle(5, 6);
            _rectangle.Perimeter();
            Figure _triangle = new Triangle(4, 8, 3);
            _triangle.Perimeter();
        }

        abstract class Figure
        {
            public abstract void Perimeter();
        }

        class Rectangle : Figure
        {
            public int width;
            public int height;
            public int perimeter;

            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public override void Perimeter()
            {
                perimeter = 2 * width + 2 * height;
                Console.WriteLine(perimeter);
            }
        }

        class Triangle : Figure
        {
            public int side1;
            public int side2;
            public int side3;
            public int perimeter;

            public Triangle(int s1, int s2, int s3)
            {
                this.side1 = s1;
                this.side2 = s2;
                this.side3 = s3;
            }

            public override void Perimeter()
            {
                perimeter = side1 + side2 + side3;
                Console.WriteLine(perimeter);
            }
        }
    }
}
