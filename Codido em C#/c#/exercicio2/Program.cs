using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var id = Guid.NewGuid();
            id.ToString();
            Console.WriteLine(id);

            var price = 34.43;
            var texto = $"O preço do produto é {price}";
            Console.WriteLine(texto);


            var text = "Este é igual a outro";
            Console.WriteLine(text.Equals("Este é igual a outro"));
            Console.WriteLine(text.Equals("este é igual a outro"));
            Console.WriteLine(text.Equals("Este é Igual a Outro",StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(text.Equals("este é igual a outro",StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(text.IndexOf("i"));
            Console.WriteLine(text.LastIndexOf("o"));
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(13,"teste "));
            Console.WriteLine(text.Remove(13,5));
          
        }
    }
}