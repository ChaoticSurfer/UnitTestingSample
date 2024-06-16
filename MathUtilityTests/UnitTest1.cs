using System;
using UnitTestingSAmple;
using Xunit;

namespace MathUtilityTests
{
    public class UnitTests
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -1, -2)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void Add_ShouldReturnSumOfTwoNumbers2(int a, int b, int expected)
        {
            // Arrange
            var mathUtility = new MathUtility();

            // Act
            var result = mathUtility.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }



        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            var mathUtility = new MathUtility();

            // Act
            var result = mathUtility.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
        {
            // Arrange
            var mathUtility = new MathUtility();

            // Act
            var result = mathUtility.Subtract(5, 3);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnProductOfTwoNumbers()
        {
            // Arrange
            var mathUtility = new MathUtility();

            // Act
            var result = mathUtility.Multiply(4, 3);

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_ShouldReturnQuotientOfTwoNumbers()
        {
            // Arrange
            var mathUtility = new MathUtility();

            // Act
            var result = mathUtility.Divide(10, 2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            var mathUtility = new MathUtility();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => mathUtility.Divide(10, 0));
        }
    }
}
