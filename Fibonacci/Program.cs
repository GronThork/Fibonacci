 using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nElement;
            string exit; 

            do
            {
                Console.WriteLine("Write n element: ");
                nElement = Convert.ToInt32(Console.ReadLine());

                if (Fibonacci.CalculateFibonacci(nElement) != nElement)
                    Console.WriteLine($"For element {nElement}, the return isnt {nElement}!");

                Console.WriteLine("Do you want to exit (Y/N): ");
                exit = Console.ReadLine();
            } while (exit.Equals("N"));


        }
    }
}
