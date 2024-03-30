using System;

namespace exerciciomario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Digite um numero entre 1 e 8: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 8);

            for (int i = 0; i < n; i++)
            {
                // Loop para a primeira pirâmide
                for (int j = 0; j < n; j++)
                {
                    if (n - i - 1 > j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }

                // Adiciona espaço entre as pirâmides
                Console.Write("  ");

                // Loop para a segunda pirâmide
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("#");
                    }
                }

                Console.WriteLine(); // Nova linha após cada linha das pirâmides
            }
        }
    }
}
