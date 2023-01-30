using System;

namespace Estructurada12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int opcion = 0;
            Console.WriteLine("1.pares o 2.impares");
            opcion = int.Parse(Console.ReadLine());
            while (opcion != 1 && opcion != 2)
            {
                Console.WriteLine("opcion no válida");
                opcion = int.Parse(Console.ReadLine());
            }
            while (i <= 10)
            {
                if (opcion==1)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
                i++;
            }
        }
    }
}
