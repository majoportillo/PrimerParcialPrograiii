using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    internal class BusquedaBinaria
    {
        public static int Buscar(int[] arreglo, int objetivo)
        {
            int izquierda = 0, derecha = arreglo.Length - 1;
            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                if (arreglo[medio] == objetivo)
                    return medio;
                if (arreglo[medio] < objetivo)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
            return -1;
        }
    }
}
