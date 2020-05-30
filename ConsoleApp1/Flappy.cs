using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy
{
    class Flappy
    {
        int Height { set; get; }

        int Width { set; get; }

        Board board;

        public Flappy (int width, int height)
        {
            Width = width;
            Height = height;
        }

        void Setup()
        {
            board = new Board(Width, Height);
        }

        public void Run()
        {
            Console.Clear();
            Setup();
            board.Write();
        }

    }

    public class Board
    {
        public int Height { set; get; }

        public int Width { set; get; }

        public Board()
        {
            Height = 20;
            Width = 80;
        }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Write()
        {
            for(int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, Height + 1);
                Console.Write("─");
            }
            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");
            }
            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition(Width + 1, i);
                Console.Write("│");
            }

            Console.SetCursorPosition(0, 0);
            Console.Write("┌");
            Console.SetCursorPosition(Width + 1, 0);
            Console.Write("┐");
            Console.SetCursorPosition(0, Height + 1);
            Console.Write("└");
            Console.SetCursorPosition(Width + 1, Height + 1);
            Console.Write("┘");
        }
    }
}
