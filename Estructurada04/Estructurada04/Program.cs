using System;

namespace Estructurada04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Dime el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el tercer numero");
            c = int.Parse(Console.ReadLine());
            if(a<b && b < c)
            {
                Console.WriteLine("Estan ordenados de menor a mayor");
            }
            else
            {
                Console.WriteLine("No estan ordenados");
            }
        }
    }
}
