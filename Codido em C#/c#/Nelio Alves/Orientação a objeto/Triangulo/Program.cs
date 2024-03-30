using System;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           Triangulo x, y;

           x = new Triangulo();
           y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triângulo x: ");
             x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triângulo y: ");
             y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areaX = x.Area();
            Console.WriteLine("Area de X = {0}" ,areaX.ToString("F4", CultureInfo.InvariantCulture));
           
            double areaY = y.Area();
            Console.WriteLine("Area de Y = {0}" ,areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            Console.WriteLine("Maior area = X");
            else
            Console.WriteLine("Maior area = Y");
        }
    }
    
}
