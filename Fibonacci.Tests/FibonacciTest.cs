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
    }
}
