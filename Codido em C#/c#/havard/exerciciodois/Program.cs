using System;

namespace exerciciodoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primero numero:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
             float num2 = float.Parse(Console.ReadLine());
             float soma = num1 +num2;
             Console.WriteLine("A soma dos numero é " + soma);
        }
    }
}
