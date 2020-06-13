using System;
namespace Shapes
{
    class Ellipse
    {
        public double SemiMajorAxis;
        public double SemiMinorAxis;
        public Ellipse()
        {
            Console.WriteLine("Ellipse being created" );
            SemiMajorAxis = 1;
            SemiMinorAxis = 1;
        }
        public Ellipse(double wide, double tall)
        {
            Console.WriteLine("");
            Console.WriteLine("Ellipse being created with SemiMajorAxis: " + wide + " and SemiMinorAxis: " + tall);
            SemiMajorAxis = wide;
            SemiMinorAxis = tall;
        }
        public Ellipse(Ellipse copy)
        {
            SemiMajorAxis = copy.SemiMajorAxis;
            SemiMinorAxis = copy.SemiMinorAxis;
        }
        public double CalculateArea()
        {
            double a = SemiMajorAxis * SemiMinorAxis * 3.14159;
            return a;
            
        }
        public double CalculatePermimeter()
        {
            double a = 2*3.14159 * Math.Sqrt((Math.Pow(SemiMajorAxis, 2) + Math.Pow(SemiMinorAxis, 2))/2);
            return a;
        }
    }
}