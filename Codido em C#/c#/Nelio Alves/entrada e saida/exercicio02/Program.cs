using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do raio do circulo");
            float raio = float.Parse(Console.ReadLine());
            double pi = 3.14159 ;
            float area = (float)pi*(raio*raio);
            Console.WriteLine("Area é igual a {0}", area);
        }
    }
}
