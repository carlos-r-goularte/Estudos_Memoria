using System;

namespace Estudos_Memoria_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Double? teste1 = null;
            Double? teste2 = 10.0;

            Console.WriteLine(teste1 + " | " + teste2);

            Console.WriteLine(teste1.HasValue + " | " + teste2.HasValue);

            Console.WriteLine(teste1.GetValueOrDefault() + " | " + teste2.GetValueOrDefault());

            if (teste1.HasValue)
                Console.WriteLine(teste1.Value);
            else
                Console.WriteLine("teste1 é null");

            if(teste2.HasValue)
                Console.WriteLine(teste2.Value);
            else
                Console.WriteLine("teste2 é null");


            double a = teste1 ?? 5;
            double b = teste2 ?? 5;

            Console.WriteLine(a + " | " + b);
        }
    }
}
