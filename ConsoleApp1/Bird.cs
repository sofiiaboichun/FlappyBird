using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bird
    {
        public int X { get; set; }
        public int Y { get; set; }

        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;

        public Bird(int x, int y)
        {
            X = x;
            Y = y;
            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();
        }

        void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;

            }
        }

        public void Logic()
        {
            Input();
            if (consoleKey == ConsoleKey.Spacebar)
            {
                Up();
            }
            else
            {
                Down();
            }
            consoleKey = ConsoleKey.A;
        }

        void Down()
        {
            Write("\0");
            Y++;
            Write();
        }

        void Up()
        {
            Write("\0");
            Y--;
            Write();
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(X, Y - 1);
            Console.Write("▄");
            Console.SetCursorPosition(X - 1, Y - 1);
            Console.Write("▄");
            Console.SetCursorPosition(X - 1, Y);
            Console.Write("▀");
            Console.SetCursorPosition(X, Y);
            Console.Write("▀");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Write(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(X, Y - 1);
            Console.Write(str);
            Console.SetCursorPosition(X - 1, Y - 1);
            Console.Write(str);
            Console.SetCursorPosition(X - 1, Y);
            Console.Write(str);
            Console.SetCursorPosition(X, Y);
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
