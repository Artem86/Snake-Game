using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            MapBorder border = new MapBorder(Console.WindowWidth, Console.WindowHeight, '$');
            Console.ReadLine();
        }
    }
}