using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlapFlap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console Flappy Bird";
            Console.CursorVisible = false;
            Flappy flappy = new Flappy(25,110);
            flappy.Run();
            Console.ReadKey();
        }
    }
}
