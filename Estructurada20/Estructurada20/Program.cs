using System;

namespace Estructurada20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, n, max = 0;
            while (i <= 10)
            {
                Console.WriteLine("dime el numero");
                n = int.Parse(Console.ReadLine());
                if (max < n)
                {
                    max = n;
                }
                i++;
            }
            Console.WriteLine("el maximo es "+max);
        }
    }
}
