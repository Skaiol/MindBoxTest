using System;

namespace Library.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"{radius} must be greater then 0", nameof(radius));
            }
            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}