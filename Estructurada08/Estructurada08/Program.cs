using System;

namespace Estructurada08
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

            if (a >= b && b >= c)
            {
                Console.WriteLine("el mayor es "+a+" el mediano es "+b+" y el menor es "+c);
            }
            else
            {
                if (a >= b && c >= b)
                {
                    if (a >= c)
                    {
                        Console.WriteLine("el mayor es "+a+" el mediano es "+c+" y el menor es "+b);
                    }
                    else
                    {
                        Console.WriteLine("el mayor es "+c+" el mediano es "+a+" y el menor es "+b);
                    }
                }
                else
                {
                    if (b >= a && b >= c)
                    {
                        if (a >= c)
                        {
                            Console.WriteLine("el mayor es "+b+" el mediano es "+a+" y el menor es "+c);
                        }
                        else
                        {
                            Console.WriteLine("el mayor es "+b+" el mediano es "+c+" y el menor es "+a);
                        }
                    }
                    else
                    {
                        if (c >= b && c >= a)
                        {
                            if (b >= a)
                            {
                                Console.WriteLine("el mayor es "+c+" el mediano es "+b+" y el menor es "+a);
                            }
                            else
                            {
                                Console.WriteLine("el mayor es "+c+" el mediano es "+a+" y el menor es "+b);
                            }
                        }
                    }
                }
            }
        }
    }
}
