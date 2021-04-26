using System;

namespace DioppNetC
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVezes = 5, meh = 33, mah = 22, mih = 11;

            for (int i=0; i < numVezes; i++)
            {   
                // String interpolation funcionalidade do C Sharp
                Console.Write($"Curso NET numero é: {i} {mah}, {meh}, {mih}");
                Console.WriteLine($"\nQuebra de linha na nova Concatenacao: {i} {mih}, {mah}, {meh}\n");
            }
        }
    }
}   