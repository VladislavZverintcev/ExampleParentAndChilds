using System;

namespace ExampleExtention
{
    class Quadrate : Figure
    {
        public  double Side { get; set; }
        public override double GetSquare()
        {
            return Math.Pow(Side, 2);
        }
        public override string ToString()
        {
            return "Quadrate";
        }
        public Quadrate(double side)
        {
            Side = side;
        }
    }
}
