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

            Circle Things = new Circle(5);
            Console.WriteLine(Things.CalculateArea());
            Console.WriteLine(Things.CalculatePermimeter());

            Ellipse AlmostCircle = new Ellipse(2, 2);
            Console.WriteLine(AlmostCircle.CalculateArea());
            Console.WriteLine(AlmostCircle.CalculatePermimeter());

            Pentagon Government = new Pentagon(3);
            Console.WriteLine(Government.CalculateArea());
            Console.WriteLine(Government.CalculatePermimeter());
        }
    }
}
