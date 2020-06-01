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
        Wall wall1;
        Wall wall2;
        Wall wall3;

        Message mes;

        int score;

        public Flappy (int width, int height)
        {
            Width = width;
            Height = height;
        }

        void Setup()
        {
            board = new Board(Width, Height);
            bird = new Bird(Height, Height/2);
            wall1 = new Wall(35, Width, Height);
            wall2 = new Wall(60, Width, Height);
            wall3 = new Wall(85, Width, Height);
            score = 0;
            mes = new Message();
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Setup();
                board.Write();

                Console.SetCursorPosition((Width / 2) - 4, Height + 2);
                Console.Write("SCORE : ");

                bird.Write();

                wall1.Move();
                wall2.Move();
                wall3.Move();

                Console.ReadKey(true);
                while (bird.Y < Height && bird.Y > 1)
                {
                    if (   ((bird.X >= wall1.X - 2 && bird.X <= wall1.X + 2) && (bird.Y <= wall1.Y - 1 || bird.Y >= wall1.Y + 2))
                        || ((bird.X >= wall2.X - 2 && bird.X <= wall2.X + 2) && (bird.Y <= wall2.Y - 1 || bird.Y >= wall2.Y + 2))
                        || ((bird.X >= wall3.X - 2 && bird.X <= wall3.X + 2) && (bird.Y <= wall3.Y - 1 || bird.Y >= wall3.Y + 2))
                       )
                    {
                        Console.Beep();
                        break;
                    }
                    if ( wall1.X == bird.X || wall2.X == bird.X || wall3.X == bird.X )
                    {
                        score++;
                    }
                    bird.Logic();
                    wall1.Move();
                    wall2.Move();
                    wall3.Move();
                    Console.SetCursorPosition((Width / 2) + 3, Height + 2);
                    Console.Write(score);
                    if (score == 0 && (bird.X >= wall1.X - 2 && bird.X <= wall1.X + 2) && (bird.Y <= wall1.Y - 1 || bird.Y >= wall1.Y + 2))
                    {
                        Console.SetCursorPosition(0, Height + 5);
                        Console.Write("Your score for now is ZERO! Try again!");
                    }
                    mes.NewMessage(score, Height);
                    
                    Thread.Sleep(300);
                }
            }
        }

    }
    
}
