using System;

namespace editorhtml
{
    public class Menu
    {
        public static void Show()
            {
                Console.Clear();
                Console.Backgroundcolor = "ConsoleColor.Blue";
                Console.Foregroundcolor = "Consolecolor.Black";

                DrawScreem();
                WriteOptions();
            }
        public static void DrawScreem()
        {
            Console.WriteLine("+");
            for(int i = 0; i <=30; i++)
            Console.WriteLine("-");
        
        
        Console.Write("+");
        Console.Write("\n");

        for(int lines = 0;lines <= 10;lines++)
        {
            Console.Write("|");
            for(int i = 0; i <=30; i++)
                Console.WriteLine("");
          
            Console.Write("|");
            Console.Write("\n");

        Console.WriteLine("+");
        
            for(int i = 0; i <=30; i++)
            Console.WriteLine("-");
        
        Console.Write("+");
        Console.Write("\n");
    }
        }
        
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
        }
}
}