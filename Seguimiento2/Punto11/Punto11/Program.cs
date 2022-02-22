using System;

namespace Punto11
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor;
            Console.WriteLine("Ingrese N1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese N2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese N3: ");
            int n3 = int.Parse(Console.ReadLine());

            if((n1>n2) && (n1>n3))
            {
                mayor = n1;
            }
            else
            {
                if(n2>n3)
                {
                    mayor = n2;
                }
                else
                {
                    mayor = n3;
                }
            }
            Console.WriteLine("El valor mayor entre " + n1 + ", " + n2 + " y " + n3 + " es " + mayor);



        }
    }
}
