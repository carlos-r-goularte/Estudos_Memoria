using System;


namespace Estudos_Memoria_1
{
    class Product
    {
        public string Name;
        public double Valor;

        public Product(string nome,double valor)
        {
            Name = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return "(" + Name + " || " + Valor + ")";
        }
    }
}