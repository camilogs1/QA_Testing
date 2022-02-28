using System;

namespace Punto11
{
    class Punto15
    {
        static void Main(string[] args)
        {
            //int pesoa, pesob, pesoc, pesod;
            Console.WriteLine("Ingrese PesoA: ");
            int pesoa = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese PesoB: ");
            int pesob = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese PesoC: ");
            int pesoc = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese PesoD: ");
            int pesod = int.Parse(Console.ReadLine());


            if ((pesoa == pesob) && (pesoa == pesoc))
            {
                if(pesod > pesoa)
                {
                    Console.WriteLine("LA ESFERA D ES LA DIFERENTE");
                }
                else
                {
                    Console.WriteLine("LA ESFERA D ES LA DIFERENTE");
                }
              
            }
            else
            {
              if((pesoa == pesob) && (pesoa == pesod))
                    {
                        Console.WriteLine("LA ESFERA C ES LA DIFERENTE");
                    if(pesoc > pesoa)
                    {
                        Console.WriteLine("Y ES DE MAYOR PESO");
                    }
                    else
                    {
                        Console.WriteLine("Y ES DE MENOR PESO");
                    }

                    }
                else
                {
                    if(((pesoa == pesoc) && (pesoa == pesod)))
                    {
                        Console.WriteLine("LA ESFERA B ES LA DIFERENTE");
                        if(pesob > pesod)
                        {
                            Console.WriteLine("Y ES DE MAYOR PESO");
                        }
                        else
                        {
                            Console.WriteLine("Y ES DE MENOR PESO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("LA ESFERA A ES LA DIFERENTE");
                        if (pesoa > pesob)
                        {
                            Console.WriteLine("Y ES DE MAYOR PESO");
                        }
                        else
                        {
                            Console.WriteLine("Y ES DE MENOR PESO");
                        }
                    }
                }
            }
        }
    }
}
