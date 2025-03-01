using System;
using System.Collections.Generic;

namespace SerieIIIParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>();
            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);

            Console.WriteLine("Personas en la cola: ");
            foreach (int item in cola)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Personas que salen de la cola: ");
            while(cola.Count >0)
            {
                int persona = cola.Dequeue();
                Console.WriteLine(persona);
            }
        }
    }
}