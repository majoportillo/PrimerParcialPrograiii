using System;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Busqueda Binaria");
            Console.WriteLine("Ingrese el tamaño de su arreglo: ");
            int tamaño = int.Parse(Console.ReadLine());
            int[] arreglo = new int[tamaño];
            Console.WriteLine("Ingrese los elementos de su arreglo: ");
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
