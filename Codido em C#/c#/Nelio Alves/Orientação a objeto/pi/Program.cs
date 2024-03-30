using System;
using System.Globalization;

namespace pi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();

          
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("A circunferencia é : {0}", circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O volume é : {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de PI é : {0}", Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));


           
        }
    }
}
