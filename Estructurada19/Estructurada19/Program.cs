using System;

namespace Estructurada19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,aprobado=0;
            double nota;
            while (i <= 30)
            {
                Console.WriteLine("Dime la nota "+i);
                nota = double.Parse(Console.ReadLine());
                if (nota >= 5)
                {
                    aprobado = aprobado + 1;
                }
                i = i + 1;
            }
            Console.WriteLine("el numero de aprobados es "+aprobado);
        }
    }
}
