using System;

namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
            Console.WriteLine("Static Void - sou independente");
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            Console.WriteLine("ponto3D Calc3 Override");
            base.CalcularDistancia3();
        }
    }
}