using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
    
}
