using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do funcionario: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas do funcionario: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora de trabalho funcionario: ");
            float valor = float.Parse(Console.ReadLine());
            Console.WriteLine("NUMBER = {0} ", codigo); 
            Console.WriteLine($"SALARY = U$ {horas* valor} ");
            
        }
    }
}
