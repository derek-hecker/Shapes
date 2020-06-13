using System;
namespace Shapes
{
    class Pentagon
    {
        public double lengthOfSide;
        public Pentagon()
        {
            Console.WriteLine("Pentagon being created");
            lengthOfSide = 1;
        }
        public Pentagon(double length)
        {
            Console.WriteLine("");
            Console.WriteLine("Pentagon being created with side length of "+ length);
            lengthOfSide = length;
        }
        public Pentagon(Pentagon copy)
        {
            lengthOfSide = copy.lengthOfSide;
        }
        public double CalculateArea()
        {
            double a = lengthOfSide;
            a = Math.Pow(a, 2) * .25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));
            return a;
        }
        public double CalculatePermimeter()
        {
            double a = lengthOfSide;
            a = a * 5;
            return a;
        }
    }
}