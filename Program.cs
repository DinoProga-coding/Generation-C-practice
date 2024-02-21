using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.SetCursorPosition(20, 10);
            for (int i = 0; i < 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('=');
            }
            Console.WriteLine(" ");
            Console.SetCursorPosition(20, 11);
            for (int i = 0; i < 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("#");
            }
            Console.SetCursorPosition(20, 12);
            for (int i = 0; i < 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("#");
            }
            Console.WriteLine(" ");
            Console.SetCursorPosition(20, 13);
            for (int i = 0; i < 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("#");
            }
            Console.SetCursorPosition(20, 12);
            for (int i = 0; i < 5; i++)
            {
                int num = rand.Next(0, 6);
                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (num)
                {
                    case 1:
                        Console.SetCursorPosition(24, 12);
                        Console.Write("%");
                        break;
                    case 2:
                        Console.SetCursorPosition(30, 12);
                        Console.Write("%");
                        break;
                    case 3:
                        Console.SetCursorPosition(37, 12);
                        Console.Write("%");
                        break;
                    case 4:
                        Console.SetCursorPosition(45, 12);
                        Console.Write("%");
                        break;
                    case 5:
                        Console.SetCursorPosition(65, 12);
                        Console.Write("%");
                        break;
                }
            }
            for (int i = 0; i < 12; i++)
            {
                int num = rand.Next(0, 12);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                switch (num)
                {
                    case 1:
                        Console.SetCursorPosition(22, 9);
                        Console.Write('!');
                        break;
                    case 2:
                        Console.SetCursorPosition(25, 9);
                        Console.Write('!');
                        break;
                    case 3:
                        Console.SetCursorPosition(29, 9);
                        Console.Write('!');
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(32, 9);
                        Console.Write('!');
                        break;
                    case 5:
                        Console.SetCursorPosition(37, 9);
                        Console.Write('!');
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(41, 9);
                        Console.Write('!');
                        break;
                    case 7:
                        Console.SetCursorPosition(44, 9);
                        Console.Write('!');
                        break;
                    case 8:
                        Console.SetCursorPosition(45, 9);
                        Console.Write('!');
                        break;
                    case 9:
                        Console.SetCursorPosition(46, 9);
                        Console.Write('!');
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(46, 9);
                        Console.Write('!');
                        break;
                    case 11:
                        Console.SetCursorPosition(52, 9);
                        Console.Write('!');
                        break;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                int num = rand.Next(0, 7);
                Console.ForegroundColor = ConsoleColor.Gray;
                switch (num)
                {
                    case 1:
                        Console.SetCursorPosition(23, 9);
                        Console.Write("#");
                        break;
                    case 2:
                        Console.SetCursorPosition(24, 9);
                        Console.Write("#");
                        break;
                    case 3:
                        Console.SetCursorPosition(33, 9);
                        Console.Write("#");
                        break;
                    case 4:
                        Console.SetCursorPosition(34, 9);
                        Console.Write("#");
                        break;
                    case 5:
                        Console.SetCursorPosition(35, 9);
                        Console.Write("#");
                        break;
                    case 6:
                        Console.SetCursorPosition(65, 9);
                        Console.Write("####");
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
