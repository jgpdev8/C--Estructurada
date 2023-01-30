using System;

namespace Estructurada07
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, sol1,sol2, raiz;
            Console.WriteLine("Dime el valor de a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el valor de b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el valor de c");
            c = int.Parse(Console.ReadLine());
            raiz = Math.Sqrt((b * b) + (-4 * a * c));
            sol1 = (-b + raiz) / (2 * a);
            sol2 = (-b - raiz) / (2 * a);
            Console.WriteLine("las soluciones son"+sol1+" y "+sol2);
        }
    }
}
