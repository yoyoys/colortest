using System;
using System.Linq;

namespace colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var text = "***";
            var colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
            var darkColors = colors.Take(8);
            var lightColors = colors.Skip(8);
            
            Console.Write(new String(' ', 14));

            foreach (var color in darkColors) {
                var colorName = color.ToString().Take(7);
                Console.Write(new string(colorName.ToArray()).PadRight(7));
                Console.Write(" ");
            }

            Console.WriteLine();
            foreach (var fore in colors)
            {
                Console.Write(fore.ToString().PadLeft(13));
                Console.Write(' ');
                foreach (var back in darkColors)
                {
                    Console.ForegroundColor = fore;
                    Console.BackgroundColor = back;
                    Console.Write($" {text} ");

                    Console.ResetColor();
                    Console.Write("   ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write(new String(' ', 14));

            foreach (var color in lightColors) {
                var colorName = color.ToString().Take(7);
                Console.Write(new string(colorName.ToArray()).PadRight(7));
                Console.Write(" ");
            }

            Console.WriteLine();

            foreach (var fore in colors)
            {
                Console.Write(fore.ToString().PadLeft(13));
                Console.Write(' ');
                foreach (var back in lightColors)
                {
                    Console.ForegroundColor = fore;
                    Console.BackgroundColor = back;
                    Console.Write($" {text} ");

                    Console.ResetColor();
                    Console.Write("   ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}