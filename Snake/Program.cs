using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            StartUp.Configure();
            Console.CursorVisible = false;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            MapBorder border = new MapBorder(Console.WindowWidth, Console.WindowHeight, '$', StartUp.SnakeContainer.GetInstance<IPointWriter>());
            Console.ReadLine();
        }
    }
}