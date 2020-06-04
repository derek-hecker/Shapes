using System;


namespace Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            Square example = new Square(5);
            Console.WriteLine(example.CalculateArea());
            Console.WriteLine(example.CalculatePermimeter());

            Rectangle Box = new Rectangle(3, 5);
            Console.WriteLine(Box.CalculateArea());
            Console.WriteLine(Box.CalculatePermimeter());
        }
    }
}
