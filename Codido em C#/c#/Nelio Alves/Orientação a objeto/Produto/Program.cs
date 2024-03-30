using  System;
using System.Globalization;
namespace produto
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            
            Produto pr = new Produto(nome,preco,quantidade);

            Console.WriteLine("Dados do produto: {0}" , pr);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados no estoque : ");
            int qte = int.Parse(Console.ReadLine());
            pr.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}" ,pr);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos no estoque : ");
             qte = int.Parse(Console.ReadLine());
            pr.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}" ,pr);
                
        }
    }
}

