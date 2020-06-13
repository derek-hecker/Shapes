using System;
namespace Shapes
{
    class Circle
    {
        public double radius;
        public Circle()
        {
            Console.WriteLine("Circle being created");
            radius = 1;
        }
        public Circle(double length)
        {
            Console.WriteLine("");
            Console.WriteLine("Circle being created with radius of " + length);
            radius = length;
        }
        public Circle(Circle copy)
        {
            radius = copy.radius;
        }
        public double CalculateArea()
        {
            double a = (radius * radius) * 3.14159;
            return a;
        }
        public double CalculatePermimeter()
        {
            double a = radius * 2 * 3.14159; ;
            return a;
        }
    }
}