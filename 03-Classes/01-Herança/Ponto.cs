using System;

namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia =  0;
        
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
            distancia++;
            Console.WriteLine($"Construtor: {this.distancia}\n");
        }

        protected void CalcularDistancia()
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2()
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
            Console.WriteLine("classe ponto Calc3 default\n");
        }
    }
}