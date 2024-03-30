using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine("A soma de {0} + {1} é igual a {2}", num1, num2, resultado);
        }
    }
}