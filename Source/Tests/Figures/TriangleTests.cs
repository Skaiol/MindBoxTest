using System;
using Library.Figures;
using Xunit;

namespace Tests.Figures
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateSquare_CorrectSides_CorrectSquare()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = 4;
            const int side3 = 5;
            var triangle = new Triangle(side1, side2, side3);
            
            // Act
            var result = triangle.CalculateSquare();

            // Assert
            Assert.Equal(6, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 3)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 3, -5)]
        public void Ctor_WrongSides_Exception(int side1, int side2, int side3)
        {
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void IsRightTriangle_PythagoreanTheoremHolds_TriangleIsRight()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = 4;
            const int side3 = 5;
            var triangle = new Triangle(side1, side2, side3);
            
            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.True(result);
        }
    }
}