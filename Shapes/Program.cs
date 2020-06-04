using System;


namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square example = new Square(5);
            Console.WriteLine(example.CalculateArea());
            Console.WriteLine(example.CalculatePermimeter());
        }
    }
}
