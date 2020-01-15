using System;
using Library.Figures;
using Xunit;

namespace Tests.Figures
{
    public class CircleTests
    {
        [Fact]
        public void CalculateSquare_SimpleTest_CorrectAsExpected()
        {
            // Arrange
            const int radius = 2;
            var circle = new Circle(radius);
            
            // Act
            var result = circle.CalculateSquare();
            var expected = Math.Pow(radius, 2) * Math.PI;

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-13)]
        public void Ctor_WrongSides_Exception(int radius)
        {
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}