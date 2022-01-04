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

            Product[] vector = new Product[quantityOfProducts];

            for (int i = 0; i < quantityOfProducts; i++)
            {
                Console.Write("Digite o nome do produto " + (i + 1) + ": ");
                string name = Console.ReadLine();

                Console.Write("Digite o valor do produto " + (i + 1) + ": ");
                double value = double.Parse(Console.ReadLine());

                vector[i] = new Product(name, value);
            }

            for (int i = 0; i < quantityOfProducts; i++)
            {
                sumVectorValue += vector[i].Value;
            }

            averageVectorValue = sumVectorValue / quantityOfProducts;
            Console.WriteLine("A média do valor dos produtos é: " +  averageVectorValue.ToString("F2"));

        }
    }
}
