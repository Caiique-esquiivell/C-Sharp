using System;
using System.Globalization;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Funcionario fun = new Funcionario();
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            Console.WriteLine();
            Console.Write("Funcionario : {0}, $  ", fun ) ;
            Console.WriteLine();
            Console.Write("Deseja aumentar o salario em  qual porcentagem? ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.Write("Dados atualizados {0}" , fun);
            
        }
    }
}
