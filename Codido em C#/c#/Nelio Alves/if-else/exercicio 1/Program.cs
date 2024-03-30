using System;
using Microsoft.Win32.SafeHandles;

namespace exercicio1
{
    class Program
    {
        static void Main(String[] arfgs)
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());
            if(num < 0)
            
                Console.WriteLine("NEGATIVO");
            else 
            Console.WriteLine("NÃO NEGATIVO");
        }
    }
}
