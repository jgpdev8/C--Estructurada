using System;

namespace Estructurada02
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno;
            Console.WriteLine("Dime el año para saber si es bisiesto o no");
            anno = int.Parse(Console.ReadLine());
            if (anno % 4 == 0)
            {
                Console.WriteLine("El año "+anno+" es bisiesto");
            }
            else
            {
                Console.WriteLine("El año "+anno+" no es bisiesto");
            }
        }
    }
}
