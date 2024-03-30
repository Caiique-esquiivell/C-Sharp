using System;

namespace exerciciotres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Você irar digitar dois numero e ira verificar se o primeiro numero é maior, menor ou igual ao segundo numero.");
            Console.WriteLine("Digite o Primero Numero:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            float num2 = float.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                Console.WriteLine("O numero {0} é maior que o numero {1} " ,num1,num2);
            }else if(num1 < num2)
            {
                 Console.WriteLine("O numero {0} é menor que o numero {1} " ,num1,num2);
            } else
            {
                 Console.WriteLine("O numero {0} é igual ao  numero {1} " ,num1,num2);
            }
        }
    }
}