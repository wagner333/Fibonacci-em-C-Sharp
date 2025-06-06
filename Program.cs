using System;

namespace program
{
    public class Program
    {
        private int quantidade;
        private int fib1;
        private int fib2;

        public Program()
        {
            quantidade = 10;
            fib1 = 0;
            fib2 = 1;
        }

        public void ExecutarFibonacci()
        {
            for (int i = 1; i <= quantidade; i++)
            {
                int fib3 = fib1 + fib2;
                Console.WriteLine(fib3);
                fib1 = fib2;
                fib2 = fib3;
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.ExecutarFibonacci();
        }
    }
}
