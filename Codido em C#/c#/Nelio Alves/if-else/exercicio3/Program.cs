using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite o primeiro numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine ("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            if(num1 % num2 == 0 || num2 % num1 == 0 )
                Console.WriteLine("SÃO MULTIPLOS");
            else
                Console.WriteLine("NÃO SÃO MULTIPLOS");
                
                    
                
        }
    }
}
