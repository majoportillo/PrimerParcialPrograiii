using System;
using System.Collections.Generic;

namespace SerieIIIParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>(); //crea una cola
            cola.Enqueue("luisa");
            cola.Enqueue("Ana");
            cola.Enqueue("Fernando"); //agrega elementos a la cola
            cola.Enqueue("Pedro");
            cola.Enqueue("Maria");

            Console.WriteLine("Personas en la cola: ");
            foreach (string persona in cola)
            {
                Console.WriteLine(persona); //muestra los elementos de la cola
            }

            Console.WriteLine("Personas que salen de la cola: "); //vacia la cola
            while(cola.Count >0)
            {
                string persona = cola.Dequeue();
                Console.WriteLine(persona);
            }

            Console.WriteLine("Personas actuales en la cola:"); //muestra los elementos de la cola osea cola ya vacia!!
            foreach (string persona in cola)
            {
                Console.WriteLine(persona);
            }
        }
    }
}