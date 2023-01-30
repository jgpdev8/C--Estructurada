using System;

namespace Estructurada21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double n, med, min = 10000, max = 0, sum = 0;
            while (i <= 10)
            {
                Console.WriteLine("dime el numero " + i);
                n = double.Parse(Console.ReadLine());
                sum = sum + n;
                if (max < n)
                {
                    max = n;
                }


                if (min > n)
                {
                    min = n;
                }

                i++;
            }
            med = sum / 10;
            Console.WriteLine("el maximo es " + max + " ,el minimo es " + min + ", y la media es " + med);
        }
    }
}
