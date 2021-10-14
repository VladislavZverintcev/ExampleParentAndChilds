namespace ExampleExtention
{
    class Rectangle : Figure
    {
        public double SideX { get; set; }
        public double SideY { get; set; }
        public override double GetSquare()
        {
            return SideX * SideY;
        }
        public override string ToString()
        {
            return "Rectangle";
        }
        public Rectangle(double sideX, double sideY)
        {
            SideX = sideX;
            SideY = sideY;
        }
    }
}
