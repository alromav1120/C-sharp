using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Factorial
{
    class Program
    {
        public int factorial(int a) {
           
            int f = 1;

            for (int x = 1; x <= a; x++) {
                f = f * x;
            }

            Console.Write("El factorial es: {0}",f.ToString());
            return a;
        }

        static void Main(string[] args)
        {
            try {

                int a;
                Program O = new Program();
                Console.Write("Dame un numero: ");
                a = Convert.ToInt32(Console.ReadLine());
                O.factorial(a);
                Console.ReadKey();
            }
            catch { 
            
            }
        }
    }
}

