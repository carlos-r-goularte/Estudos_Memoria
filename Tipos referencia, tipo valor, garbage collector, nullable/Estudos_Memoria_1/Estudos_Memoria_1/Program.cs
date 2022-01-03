using System;

namespace Estudos_Memoria_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pontos pontos = new Pontos();

            pontos.X = 10;
            pontos.Y = 20;

            Console.WriteLine(pontos);

            pontos = new Pontos();

            Console.WriteLine(pontos);
        }
    }
}
