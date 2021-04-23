using System;
using Classes.Herança;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto3D p2 = new Ponto3D(10, 20, 30);
            
            // Instacia do Objeto chamando metodo
            p1.CalcularDistancia3();
            p2.CalcularDistancia3();

            // Classe chamando metodo STATIC
            Ponto3D.Calcular();

            Console.WriteLine("Hello World!");
        }
    }
}
