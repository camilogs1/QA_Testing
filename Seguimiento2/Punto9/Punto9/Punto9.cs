using System;

namespace Punto9
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number a: ");
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter a number b: ");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter a number c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number y: ");
            int y = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter a number x: ");
            int x;

            if ((y < a) && ((a < b) && (b < c)))
            {
                x = 0;
            }
            else
            {
                if ((a <= y) && (y < b))
                {
                    x = 1;
                }
                else
                {
                    if ((b <= y) && (y < c))
                    {
                        x = 2;
                    }
                    else
                    {
                        if (c <= y)
                        {
                            x = 3;
                        }
                        else
                        {
                            x = 4;
                        }

                    }
                }

            }



        }
    }
}










