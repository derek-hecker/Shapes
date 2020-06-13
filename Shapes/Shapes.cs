using System;


namespace Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            Square example = new Square(5);
            Console.WriteLine("Area:" + example.CalculateArea());
            Console.WriteLine("Perimeter:"+example.CalculatePermimeter());

            Rectangle Box = new Rectangle(3, 5);
            Console.WriteLine("Area:" + Box.CalculateArea());
            Console.WriteLine("Perimeter:"+Box.CalculatePermimeter());

            Circle Things = new Circle(5);
            Console.WriteLine("Area:" + Things.CalculateArea());
            Console.WriteLine("Perimeter:" + Things.CalculatePermimeter());

            Ellipse AlmostCircle = new Ellipse(2, 2);
            Console.WriteLine("Area:" + AlmostCircle.CalculateArea());
            Console.WriteLine("Perimeter:" + AlmostCircle.CalculatePermimeter());

            Pentagon Government = new Pentagon(3);
            Console.WriteLine("Area:" + Government.CalculateArea());
            Console.WriteLine("Perimeter:" + Government.CalculatePermimeter());
        }
    }
}
