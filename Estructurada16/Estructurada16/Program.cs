using System;

namespace Estructurada16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dime el número a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el número b");
            b = int.Parse(Console.ReadLine());
            while (a > b)
            {
                if (b % 2 == 1)
                {
                    Console.WriteLine(b);
                }
                b = b + 1;
            }
            while (b > a)
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine(a);
                }
                a = a + 1;
            }
        }
    }
}
