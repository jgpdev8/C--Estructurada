using System;

namespace Estructurada14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n1, n2;
            Console.WriteLine("introduce el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un numero mayor al primero");
            n2 = int.Parse(Console.ReadLine());
            while (n2 <= n1)
            {
                Console.WriteLine("el numero no es mayor al primero");
                n2 = int.Parse(Console.ReadLine());
            }
            while (n1 < n2)
            {
                
                Console.WriteLine(n1);
                n1 = n1 + 1;
            }
            Console.WriteLine(n1);
        }
    }
}
