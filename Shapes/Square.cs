using System;


namespace Shapes
{
    class Square
    {
        public double lengthOfSide;
        public Square()
        {
            Console.WriteLine("Square being created");
            lengthOfSide = 1;
        } 
        public Square(double length)
        {
            Console.WriteLine("");
            Console.WriteLine("Square being created with side length of "+ length);
            lengthOfSide = length;
        }
        public Square(Square copy)
        {
            lengthOfSide = copy.lengthOfSide;
        }
        public double CalculateArea()
        {
            double a = lengthOfSide;
            a = a * a;
            return a;
        }
        public double CalculatePermimeter()
        {
            double a = lengthOfSide;
            a = a * 4;
            return a;
        }
    }
}