using System;

namespace ClaseValidacion
{
    class Punto7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", a);
            Console.WriteLine("Enter a number b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", b);

            if (a > b)
            {
                Console.WriteLine("A es mayor que B");
            }
            else
            {
                Console.WriteLine("A  es menor que B");
            }



        }
    }
}
