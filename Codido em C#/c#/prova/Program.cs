using System;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o codigo da Peça 1: ");
            int peça1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da primeira Peça: ");
            int quant1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da primera Peça:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo da Peça 2: ");
            int peça2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da segundas Peça: ");
            int quant2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da segunda Peça:");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = (valor1*quant1) + (valor2*quant2);
            Console.WriteLine("VALOR A PAGAR : R$ {0}" , resultado );
            
        
        }
    }
}
