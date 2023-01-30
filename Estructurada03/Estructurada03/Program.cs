using System;

namespace Estructurada03
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinero, dinero2;
            string moneda;
            Console.WriteLine("Dime la cantidad de dinero");
            dinero = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime a que moneda quieres pasar peseta o euro");
            moneda = Console.ReadLine();
            if (moneda == "euro")
            {
                dinero2 = dinero / 166.386;
                Console.WriteLine(dinero2);
            }
            else
            {
                if (moneda == "peseta")
                {
                    dinero2 = dinero * 166.386;
                    Console.WriteLine(dinero2);
                }
                else
                {
                    Console.WriteLine("tipo de moneda erróneo");
                }
            }
        }
    }
}
