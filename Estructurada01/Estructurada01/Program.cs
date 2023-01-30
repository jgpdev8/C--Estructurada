using System;

namespace Estructurada01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine(a+"-"+b+"="+(a-b));
            }
            else
            {
                Console.WriteLine(b+"-"+a+"="+(b-a));
            }
        }
    }
}
