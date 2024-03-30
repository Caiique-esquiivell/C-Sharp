using System;

namespace c
{
    

    class Program
        {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            if(num1%2 == 0)
            { 
                Console.WriteLine("O numero "  +  num1  +  " é par");
            }else{
                Console.WriteLine("O numero  "  +  num1  +  "  é   impar");
            }
        }
    }   
}
