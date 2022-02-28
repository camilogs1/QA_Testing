using System;

namespace Punto17
{
    class Punto17
    {
        static void Main(string[] args)
        {
            int num = 0;
            int suma = 0;
            while(num < 5)
            {
                num = num + 1;
                suma = suma + num;
            }
            Console.WriteLine("La suma es: " + suma);
        }
    }
}
