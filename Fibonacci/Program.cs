 using System;
 using System.Threading.Channels;

 namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.CalculateFibonacci(0) == 0
                ? "For element zero the result is the correct number"
                : "For element zero the result isnt the correct number");

            Console.WriteLine(Fibonacci.CalculateFibonacci(1) == 1
                ? "For element one the result is the correct number"
                : "For element zero the result isnt the correct number");

            Console.WriteLine(Fibonacci.CalculateFibonacci(12) == 144
                ? "For element 12 the result is the correct number"
                : "For element 12 the result isnt the correct number");

            Console.WriteLine("Result: " + Fibonacci.CalculateFibonacci(4000));
        }
    }
}
