using System;

namespace exerciciodinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float troflo;
            do{
                Console.WriteLine("Digite um o troco  par receber o dinheiro: ");
                troflo = float.Parse(Console.ReadLine());
            }while(troflo < 1);
            int troint = (int)Math.Round(troflo*100);
            Console.WriteLine(troint );

            int moeda25 = troint/25;
            troint %= 25;

             int moeda10 = troint/10;
            troint %= 10; 

            int moeda5 = troint/5;
            troint %= 5;

            int moeda1 = troint;
            
            int totalmoeda= moeda25 + moeda10 + moeda5 + moeda1;

            Console.WriteLine(totalmoeda);
        }
    }
}
