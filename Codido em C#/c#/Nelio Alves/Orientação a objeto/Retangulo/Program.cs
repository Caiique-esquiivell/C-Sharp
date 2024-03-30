using System;
using System.Globalization;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.Clear();
            Console.WriteLine("Entre com a Largura e a Altura");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
         
            Console.WriteLine("Area = "+ ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = "+ ret.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = "+ ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));

            

        }
    }
}