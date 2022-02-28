using System;

namespace Punto10
{
    class Program
    {
        static void Main(string[] args)
        {
            int NI = 0001, EST = 4;
            String NOMBRE = "JUAN PABLO";
            double PAT = 1500000, PATMAT;

            PATMAT = 50000;

            if ((PAT > 2000000) && (EST > 3))
            {
                PATMAT = PATMAT + 0.03 * PAT;
            }

            Console.WriteLine("EL ESTUDIANTE CON NUMERO DE INSCRIPCION, " + NI + " Y NOMBRE: " + NOMBRE + ",  DEBE PAGAR: $" + PATMAT);

        }
    }
}
