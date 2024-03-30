using System;
using Pessoa_mais_velha;

namespace PessoMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Pessoa p1,p2;
            p1 = new Pessoa();
            p2 = new Pessoa();
            

            Console.WriteLine("Dados da primeira pessoa.");
            Console.Write("Nome:");
            p1.Nome = (Console.ReadLine());
            Console.Write("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa.");
            Console.Write("Nome:");
            p2.Nome = (Console.ReadLine());
            Console.Write("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade> p2.Idade)
            Console.WriteLine("Pessoa mais velha: {0} " ,p1.Nome);
            else if(p1.Idade == p2.Idade)
            Console.WriteLine("Tanto {0} como {1} possuem a mesma idade", p1.Nome,p2.Nome);
            else
            Console.WriteLine("Pessoa mais velha : {0}",p2.Nome);
        }
    }
}

