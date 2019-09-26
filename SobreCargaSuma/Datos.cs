using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaSuma
{
    class Datos
    {
        Operaciones R = new Operaciones(); //Instanciando la Clase Operaciones

        public void ObtenerDatos() //Metodo para obtener los datos
        {
            Console.WriteLine("Ingresar 3 Datos:");
            Console.WriteLine(" ");
            Console.WriteLine("Dato 1:");

            int N1 = Convert.ToInt32(Console.ReadLine()); //Asignarle valor al N1

            Console.WriteLine(" ");

            Console.WriteLine("Dato 2:");

            int N2 = Convert.ToInt32(Console.ReadLine()); //Asignarle valor al N2

            Console.WriteLine(" ");

            Console.WriteLine("Dato 3:");

            int N3 = Convert.ToInt32(Console.ReadLine()); //Asignarle valor al N3

            int Res1 = R.Sumar(N1,N2,N3); //Respuesta 3 Parametros
            int Res2 = R.Sumar(N1,N2); //Respuesta con 2 Parametros
            int Res3 = R.Sumar(N1); //Respuesta con 1 Parametro
            int Res4 = R.Sumar(); //Respuesta sin Parametros

            Console.WriteLine("Con 3 Parametros: " +Res1);
            Console.WriteLine("Con 2 Parametros: " +Res2);
            Console.WriteLine("Con 1 Parametro: "+Res3);
            Console.WriteLine("Sin Parametros: "+Res4);
            Console.WriteLine(" ");

            Console.WriteLine("Presione una Tecla para Salir...");

            Console.ReadKey();
        }
    }
}
