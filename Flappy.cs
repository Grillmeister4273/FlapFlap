using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace FlapFlap
{
    class Flappy
    {
        int Width { set; get; }
        int Height { set; get; }
        Board board;
        Bird bird;
        public Flappy(int width, int height)
        {
            Width = width;
            Height = height;
        }
        void Setup()
        {
            board = new Board(Width, Height);
            bird = new Bird(Height, Height/2);
        }
        public void Run () 
        {
            while (true)
            {
                Console.Clear();
                Setup();
                board.Write();

                bird.Write();
                Console.ReadKey(true);
                while (bird.Y<Height && bird.Y > 1)
                {
                    bird.Logic();
                    Thread.Sleep(200);
                }
            }
        }
    }
    class Wall
    {
        public int X { set; get; }
        public int Y { set; get; }
        Random randome;
        int boardWidth;
        int boardHeight;

        public Wall(int x,int boardWidth, int boardHeight)
        {
            this.boardWidth = boardWidth;
            this.boardHeight = boardHeight;
            randome = new Random();
            X = x;
            Y = randome.Next(3, boardHeight);
        }
    }
    class Bird
    {
        public int X { set; get; }
        public int Y { set; get; }
        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;

        public Bird (int x, int y)
        {
            X=x;
            Y=y;
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
        void Up()
        {
            Write("\0");
            Y--;
            Write();
        }
        void Down()
        {
            Write("\0");
            Y++;
            Write();
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(X,Y-1);
            Console.Write("▄");
            Console.SetCursorPosition(X-1,Y-1);
            Console.Write("▄");
            Console.SetCursorPosition(X-1,Y);
            Console.Write("▀");
            Console.SetCursorPosition(X,Y);
            Console.Write("▀");
            Console.ForegroundColor= ConsoleColor.White;
        }
        public void Write(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
    public class Board
    {
        public int Hight { set; get; }
        public int Width { set; get; }

        public Board()
        {
            Hight = 20;
            Width = 20;
        }

        public Board(int hight, int width)
        {
            Hight = hight;
            Width = width;
        }
        public void Write ()
        {
            for (int i = 1;i <= Width;i++) 
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, Hight+1);
                Console.Write("─");
            }
            for (int i = 1; i <= Hight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");
            }
            for (int i = 1; i <= Hight; i++)
            {
                Console.SetCursorPosition(Width+1, i);
                Console.Write("│");
            }
            Console.SetCursorPosition(0, 0);
            Console.Write("┌");
            Console.SetCursorPosition(Width+1, 0);
            Console.Write("┐");
            Console.SetCursorPosition(0, Hight+1);
            Console.Write("└");
            Console.SetCursorPosition(Width +1, Hight+1);
            Console.Write("┘");
        }
    }
}
