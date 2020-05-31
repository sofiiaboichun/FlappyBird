using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Flappy
    {
        int Height { set; get; }

        int Width { set; get; }

        Board board;
        Bird bird;

        public Flappy (int width, int height)
        {
            Width = width;
            Height = height;
        }

        void Setup()
        {
            board = new Board(Width, Height);
            bird = new Bird(Height, Height/2);
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Setup();
                board.Write();
                bird.Write();

                Console.ReadKey(true);
                while (bird.Y < Height && bird.Y > 1)
                {
                    bird.Logic();
                    Thread.Sleep(300);
                }
            }
        }

    }
    
}
