using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
                Console.WriteLine(Fib(i));
        }

        static int Fib(int n)
        {
            if (n < 2)
                return n;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
    }
}
