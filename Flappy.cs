using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlapFlap
{
    class Flappy
    {
        int Width { set; get; }
        int Height { set; get; }
        Board board;
        public Flappy(int width, int height)
        {
            Width = width;
            Height = height;
        }
        void Setup() { board = new Board(Width, Height); }
        public void Run () 
        { 
            Console.Clear();
            Setup();
            board.Write();
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
        void Input ()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }
        }
        public void Logic ()
        {

        }
        void Up()
        {
            Y--;
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
            Width = 80;
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
