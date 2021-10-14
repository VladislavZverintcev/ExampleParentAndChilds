using System;
using System.Collections.Generic;

namespace ExampleExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create FiguresCollection and insert into collection new objects is Childs of class Figure
            var figures = new List<Figure> { new Quadrate(10), new Circle(5.64), new Rectangle(5, 20) };

            //Get Square of Every Figure into Collection and print this in console
            foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.ToString()} square: {figure.GetSquare()}");
            }
            //And Get summ of squares and print to console
            double summOfSquare = 0;
            foreach (var figure in figures)
            {
                summOfSquare = summOfSquare + figure.GetSquare();
            }
            Console.WriteLine($"SummOfSquare: {summOfSquare}");
            Console.ReadKey();

            //You can do:
            //var circle = new Circle(30);
            //Figure fig = circle;
            //And if Figure was not abstract
            //Figure f = new Figure();
            //Circle c = f;
        }
    }
}
