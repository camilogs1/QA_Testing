using System;

namespace Punto12
{
    class Program
    {
        static void Main(string[] args)
        {
            String NOM;
            int NHT, HET, HEE8;
            double VHN, SALARIO;

            NOM = "elias jose";
            NHT = 53;
            VHN = 4000;

            if (NHT > 40)
            {
                HET = NHT - 40;
                if (HET > 8)
                {
                    HEE8 = HET - 8;
                    SALARIO = (40 * VHN) + (16 * VHN) + (HEE8 * 3 * VHN);
                }
                else
                    SALARIO = (40 * VHN) + (HET * 2 * VHN);
            }
            else
                SALARIO = NHT * VHN;

            Console.WriteLine("El trabajador, "+NOM+" Devengp: $"+SALARIO);
        }
    }
}
