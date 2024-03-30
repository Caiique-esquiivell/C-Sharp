using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            int num4 = int.Parse(Console.ReadLine());
            int diferença = num1*num2-num3*num4;
            Console.WriteLine("Diferença = {0}",diferença);
        }
    }
}
