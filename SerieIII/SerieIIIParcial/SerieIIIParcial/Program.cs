using System;
using System.Collections.Generic;

namespace SerieIIIParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>();
            cola.Enqueue("luisa");
            cola.Enqueue("Ana");
            cola.Enqueue("Fernando");
            cola.Enqueue("Pedro");
            cola.Enqueue("Maria");

            Console.WriteLine("Personas en la cola: ");
            foreach (string persona in cola)
            {
                Console.WriteLine(persona);
            }

            Console.WriteLine("Personas que salen de la cola: ");
            while(cola.Count >0)
            {
                string persona = cola.Dequeue();
                Console.WriteLine(persona);
            }

            Console.WriteLine("Personas actuales en la cola:");
            foreach (string persona in cola)
            {
                Console.WriteLine(persona);
            }
        }
    }
}