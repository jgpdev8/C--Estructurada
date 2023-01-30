using System;

namespace Estructurada17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, suma=0;
            while (i <= 1000)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                    Console.WriteLine(suma);
                }
                
                i++;
            }
        }
    }
}
