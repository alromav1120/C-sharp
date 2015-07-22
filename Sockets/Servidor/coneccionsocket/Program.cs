using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net; // Agregar Librerias
using System.Net.Sockets; // Agregamos librerias

namespace coneccionsocket
{
    class Program
    {
        static void Main(string[] args)
        {
            conectar();
        }

        /*PASOS PARA CONECTARSE A UN SOCKET
         1.- Agregar las librerias .NET  y .Net.Sockets   
         2.- Creamos un objeto de tipo socket
         3.- Necesitamos una direccion Ip y un puerto de conexion
         4.- Creamos un Servidor 
         5.- Creamos un cliente y lo conectamos    
         */


        public static void conectar() {

            Socket S = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            // AddressFamily --- Indica el servicio de direcciones
            // SocketType --- especifica el tipo de spcket
            //  ProtocolType -- Tipo de protocolo a usar 

            IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 1234);

            // Paso 3 escucha al cliente en toda la red

            try {

                S.Bind(direccion);
            
                // Asociamos el socket a la direccion
                S.Listen(100);
                // Colocamos al socket en modo escucha
           
                S.Accept();

                // Creamos un nuevo socket para empezar a trabajar con el
                // La aplicacion queda en reposo hasta que se conecte un cliente

                // Una vez conectado sigue su camino

                Console.WriteLine("Conectado con exito!");
                

               
                // Luego se cierra

            }

            catch (Exception error) {

                Console.WriteLine("Error {0}",error.ToString());
            
            }

            S.Close();
            Console.ReadKey();

        }
    }
}
