using System;
namespace RobertoCobeña3A6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su número entero:");
            int num1 = int.Parse(Console.ReadLine());
            for (int j = 0; j < num1; ++j)
            {
                for (int i = 0; i < num1 - j - 1; ++i)
                    Console.Write(" ");
                for (int i = 0; i < 2 * j + 1; ++i)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (int j = num1 - 2; j >= 0; --j)
            {
                for (int i = 0; i < num1 - j - 1; ++i)
                    Console.Write(" ");
                for (int i = 0; i < 2 * j + 1; ++i)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}