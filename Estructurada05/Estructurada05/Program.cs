using System;

namespace Estructurada05
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
            if(a+1==b&&b+1==c)
            {
                Console.WriteLine("Los numeros son consecutivos");
            }
            else
            {
                Console.WriteLine("los numeros no son consecutivos");
            }
            

            
        }
    }
}
