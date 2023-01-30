using System;

namespace Estructurada18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double n=1, suma = 0,media;

            Console.WriteLine("Introduce un número de la serie");
            n = double.Parse(Console.ReadLine());

            while (n > 0)
            {
                suma = suma + n;
                i++;
                Console.WriteLine("Introduce un número de la serie");
                n = double.Parse(Console.ReadLine());

            }
            
            media =suma / i;
            Console.WriteLine("la media es "+media);
;
            
        }
    }
}
