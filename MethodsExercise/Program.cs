// See https://aka.ms/new-console-template for more information
using System;

namespace MethodsExercise
{
    class Program
    {
        
        public static int Add(params int[] list)
        {
            int sum = 0;
            for (long i = 0; i < list.Length; i++)
                sum += list[i];

            return sum;
        }
        public static int Multiply(params int[] list)
        {
            int product = 1;
            for (long i = 0; i < list.Length; i++)
                product += list[i];
            return product;
        }

        public static int Subtract(int a, int b)
        {
            return (a-b);
        }
        public static int Divide(int a, int b)
        {
            return (a/b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world.");
            var name = Console.ReadLine();

            var result = Add(10, 20);


        }

    }
}
