using System;
using System.Linq;

namespace Library.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        /// <exception cref="ArgumentException"></exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0)
            {
                throw new ArgumentException($"{side1} must be greater then 0", nameof(side1));
            }

            if (side2 <= 0)
            {
                throw new ArgumentException($"{side2} must be greater then 0", nameof(side2));
            }

            if (side3 <= 0)
            {
                throw new ArgumentException($"{side3} must be greater then 0", nameof(side3));
            }

            if ((side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) == false)
            {
                throw new ArgumentException("Triangle with current sides does not exist");
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateSquare()
        {
            var halfPerimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(halfPerimeter
                             * (halfPerimeter - _side1)
                             * (halfPerimeter - _side2)
                             * (halfPerimeter - _side3));
        }

        /// <remarks>
        /// Кого-то может смутить, что в методе создается 2 массива, а потом еще и тяжеловесный LINQ.
        /// Без заявленных требований к производительности во главу угла ставлю компактность и лаконичность.
        /// </remarks>
        public bool IsRightTriangle()
        {
            double[] sides = {_side1, _side2, _side3};
            var maxSide = sides.Max();
            return sides.Except(new[] {maxSide})
                .Select(x => Math.Pow(x, 2))
                .Sum()
                .Equals(Math.Pow(maxSide, 2));
        }
    }
}