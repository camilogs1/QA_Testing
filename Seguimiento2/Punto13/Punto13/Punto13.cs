using System;

namespace Punto13
{
    class Punto13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la compra: ");
            int valorcomp = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese color");
            string color = (Console.ReadLine());
            int pdes;
            if (color == "BLANCO")
            {
                pdes = 0;
            }
            else
            {
                if(color=="VERDE")
                {
                    pdes = 10;
                }
                else
                {
                    if(color=="AMARILLO")
                    {
                        pdes = 25;
                    }
                    else
                    {
                        if(color=="AZUL")
                        {
                            pdes = 50;
                        }
                        else
                        {
                            pdes = 100;
                        }
                    }
                }
            }
            int valpag = valorcomp - ((pdes * valorcomp) / 100);
            Console.WriteLine("El cliente debe pagar " + valpag);

        }
    }
}
