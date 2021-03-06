using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public static class Fibonacci
    {
        public static int CalculateFibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(n)} must be positive");
            }

            return n switch
            {
                0 => 0,
                1 => 1,
                _ => CalculateFibonacci( n - 1) + CalculateFibonacci(n - 2),
            };
        }
    }
}
