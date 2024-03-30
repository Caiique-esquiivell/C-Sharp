using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("hello," +  nome);
        }
    }
}

