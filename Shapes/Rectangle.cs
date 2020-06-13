using System;
using System.Runtime.InteropServices.ComTypes;

namespace Shapes
{
    class Rectangle
    {
        public double width;
        public double height;
        public Rectangle()
        {
            Console.WriteLine("Rectangle being created");
            width = 1;
            height = 1;
        }
        public Rectangle(double wide, double tall)
        {
            Console.WriteLine("");
            Console.WriteLine("Rectangle being created with a width of " + wide + " and a height of " + tall);
            width = wide;
            height = tall;
        }
        public Rectangle(Rectangle copy)
        {
            width = copy.width;
            height = copy.height;
        }
        public double CalculateArea()
        {
            double a = width * height;
            return a;
        }
        public double CalculatePermimeter()
        {
            double a = (width * 2)+(height*2);
            return a;
        }
    }
}
