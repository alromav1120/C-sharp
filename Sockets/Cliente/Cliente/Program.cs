using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Creamos objeo de tipo socket
            IPEndPoint cliented = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            try
            {

                
                S.Connect(cliented);
                Console.WriteLine("Conectado!");

            }
            catch (Exception error)
            {

                Console.WriteLine("Error {0}", error.ToString());
                Console.ReadKey();
            }

            S.Close();
            Console.ReadKey();
            
        }
    }
}
