using System;

namespace Estructurada15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Dime el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            while (n1 > n2)
            {
                Console.WriteLine(n1);
                n1 = n1 - 1;
            }
            Console.WriteLine(n1);
            while (n1 < n2)
            {
                Console.WriteLine(n1);
                n1 = n1 + 1;
            }
            Console.WriteLine(n1);
        }
    }
}
