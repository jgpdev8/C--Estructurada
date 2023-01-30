using System;

namespace Estructurada13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, num; ;
            Console.WriteLine("Dime el numero que quieras multiplicar");
            num = int.Parse(Console.ReadLine());
            while (i <= 10)
            {
                i++;
                Console.WriteLine(num * i);
            }
            
        }
    }
}
