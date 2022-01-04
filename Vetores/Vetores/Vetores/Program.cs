using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumVectorValue = 0, averageVectorValue;

            Console.Write("Digite a quantidade de produtos que serão calculados: ");
            int quantityOfProducts = int.Parse(Console.ReadLine());

            string[] vectorName = new string[quantityOfProducts];
            double[] vectorValue = new double[quantityOfProducts];

            for (int i = 0; i < quantityOfProducts; i++)
            {
                Console.Write("Digite o nome do produto " + (i + 1) + ": ");
                vectorName[i] = Console.ReadLine();

                Console.Write("Digite o valor do produto " + (i + 1) + ": ");
                vectorValue[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantityOfProducts; i++)
            {
                sumVectorValue += vectorValue[i];
            }

            averageVectorValue = sumVectorValue / quantityOfProducts;
            Console.WriteLine("A média do valor dos produtos é: " +  averageVectorValue.ToString("F2"));

        }
    }
}
