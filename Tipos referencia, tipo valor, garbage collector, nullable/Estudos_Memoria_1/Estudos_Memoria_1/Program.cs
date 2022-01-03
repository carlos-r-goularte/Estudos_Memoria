using System;

namespace Estudos_Memoria_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1,p2;
            p1 = new Product("TV",1000);
            p2 = new Product("Radio",500);

            
            Console.WriteLine(p1);
            Console.WriteLine(p2);



            p1 = p2;

            Console.WriteLine(p1);

            p2 = null;

            Console.WriteLine(p2);
        }
    }
}
