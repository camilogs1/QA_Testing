using System;

namespace Seguimiento2
{
    class Punto8
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int c = 8;
            int d = 7;
            int e = 1;

            if (a == 10)
            {
                Console.WriteLine("You entered {0}", a);
                if (b == 2)
                {
                    Console.WriteLine("You entered {0}", b);
                }
                else {
                    Console.WriteLine("Error");
                    if (c == 8)
                    {
                        Console.WriteLine("You entered {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
            }else
            {
                Console.WriteLine("Error");
                if (d == 7)
                {
                    Console.WriteLine("You entered {0}", d);
                    if (e == 1)
                    {
                        Console.WriteLine("You entered {0}", e);
                    }else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }



        }
    }
}
