using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rombos
{
   

    class Program
    {

        public int rombo(int a)
        {
            int b = a;
            int c = b - 1;
            int k = c;
            int mitad =(int)(c / 2);
            int d = mitad;
            int e=d;

           
            for (int x = 0; x < a;x++ )
            {
                if (x <= mitad)
                {
                    e = e + 1;
                    for (int j = 0; j < (a - e); j++)
                    {
                        Console.Write(" ");
                    }
                    
                    for (int j = 0; j < (a - c); j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                    c = c - 1;
                }

                else {

                    for (int j = 0; j < (a - k); j++)
                    {
                        Console.Write(" ");
                    }
                    k = k - 1;

                    d = d + 1;
                    for (int j = 0; j < (a - d); j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();           
                }
                
            }


            return a;
            
        }

        static void Main(string[] args)
        {
            try
            {
                Program O = new Program();
                int a;
                Console.Write("Dame un numero: ");
                a = Convert.ToInt32(Console.ReadLine());
                O.rombo(a);

                Console.ReadKey();
            }

            catch {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
        }
    }
}
