using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaSuma
{
    class Operaciones
    {
        public int Sumar(int A, int B, int C) //Metodo con 1 Parametro
        {
            return A + B + C;
        }

        public int Sumar(int A, int B) //Metodo con 2 Parametros
        {
            return A + B;
        }

        public int Sumar(int A) //Metodo con 3 Parametros
        {
            return A+5;
        }

        public int Sumar() //Metodo sin Parametro
        {
            return 1 + 3;
        }
    }
}
