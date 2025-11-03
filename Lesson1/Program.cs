using System;
using System.Text;

namespace Lesson1111
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Мое имя: ...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Мой город: ...");
            Console.ResetColor(); // Не забудьте сбросить цвет в конце!
            Console.WriteLine();
            Console.WriteLine("8 messages will be printed line by line: ");
            Console.WriteLine("1 line of text");
            Console.WriteLine("2 line of text");
            Console.WriteLine("3 line of text");
            Console.WriteLine("4 line of text");
            Console.WriteLine("5 line of text");
            Console.WriteLine("6 line of text");
            Console.WriteLine("7 line of text");
            Console.WriteLine("8 line of text");
            
            Console.ReadLine();
        }
    }
}
