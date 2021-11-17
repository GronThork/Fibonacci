using System;
using Xunit;
using Fibonacci;
namespace Fibonacci.Tests
{
    public class FibonacciTest
    {
        [Fact]
        public void CheckValueIsCorrectWhenIsZero()
        {
            int expected = 0;
            int actual = Fibonacci.CalculateFibonacci(0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckValueIsCorrectWhenIsOne()
        {
            int expected = 1;
            int actual = Fibonacci.CalculateFibonacci(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckValueIsCorrectWhenIsEleven()
        {
            int expected = 89;
            int actual = Fibonacci.CalculateFibonacci(11);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckValueIsCorrectWhenIsNegativeNumber()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.CalculateFibonacci(-1));
        }
    }
}
