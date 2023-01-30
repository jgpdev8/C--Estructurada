using System;

namespace Estructurada06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Dime el numero");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                num = num * (-1);
            }


            if (num >= 10000)
            {
                Console.WriteLine("el numero tiene 5 cifras");
            }
            else
            {
                if (num >= 1000)
                {
                    Console.WriteLine("el numero tiene 4 cifras");
                }
                else
                {
                    if (num >= 100)
                    {
                        Console.WriteLine("el numero tiene 3 cifras");
                    }
                    else
                    {
                        if (num >= 10)
                        {
                            Console.WriteLine("el numero tiene 2 cifras");
                        }
                        else
                        {
                            Console.WriteLine("el numero tiene 1 cifra");
                        }
                    }
                }
            }

        }
    }
}
