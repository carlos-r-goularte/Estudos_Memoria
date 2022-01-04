using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int quantidadeDeLeituras = int.Parse(Console.ReadLine());

            double[] vetor = new double[quantidadeDeLeituras];

            for (int i = 0; i < quantidadeDeLeituras; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());

            }

            double alturaSoma = 0.0;

            for (int i = 0; i < quantidadeDeLeituras; i++)
            {
                alturaSoma += vetor[i];
            }

            double alturaMedia = alturaSoma / quantidadeDeLeituras;

            Console.WriteLine("Altura Média: " + alturaMedia.ToString("F2"));
        }
    }
}
