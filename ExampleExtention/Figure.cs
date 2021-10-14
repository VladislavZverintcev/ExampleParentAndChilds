using System.Windows;

namespace ExampleExtention
{
    public abstract class Figure
    {
        public Point CenterPoint { get; set; }
        public abstract double GetSquare();
    }
}
