using System;

namespace Punto14
{
    class Program
    {
        static void Main(string[] args)
        {
            double VD1, VD2, VD3, SALAR, TOTVEN, PORVEN, SALAR1, SALAR2, SALAR3;

            VD1 = 4200000;
            VD2 = 250000;
            VD3 = 3300000;
            SALAR = 380320;

            TOTVEN = VD1 + VD2 + VD3;
            PORVEN = 0.33 * TOTVEN;

            if (VD1 > PORVEN) {
                SALAR1 = SALAR + (0.2 * SALAR);
            }   else{
                SALAR1 = SALAR;
            }

            if(VD2 > PORVEN) {
                SALAR2 = SALAR + (0.2 * SALAR);
            }   else {
                SALAR2 = SALAR;
            }

            if (VD3 > PORVEN)
            {
                SALAR3 = SALAR + (0.2 * SALAR);
            }   else {
                SALAR3 = SALAR;
            }

            Console.WriteLine("SALARIO VENDEDORES DEPTO.1: " + SALAR1 + ", SALARIO VENDEDORES DEPTO.2: " + SALAR2 + ", SALARIO VENDEDORES DEPTO.3: " + SALAR3);
        }
    }
}
