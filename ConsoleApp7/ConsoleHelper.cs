using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Factory
{
    public class ConsoleHelper
    {
        public static void WriteLineColored(string text, ConsoleColor color)
        {
            ConsoleColor orgColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = orgColor;
        }

        public static void WriteColored(string text, ConsoleColor color)
        {
            ConsoleColor orgColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = orgColor;
        }
    }
}
