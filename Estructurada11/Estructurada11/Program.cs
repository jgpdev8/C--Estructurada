using System;

namespace Estructurada11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,j=0;
            while (j < 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    j++;
                }
                i++;
            }
        }
    }
}
