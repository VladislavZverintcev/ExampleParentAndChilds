using System;

namespace ExampleExtention
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return "Circle";
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
