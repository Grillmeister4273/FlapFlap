using System;
using System.Collections.Generic;
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
            for (int i = 1; i <= Hight; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 1; i <= Hight; i++)
            {
                Console.SetCursorPosition(i, 0);
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
