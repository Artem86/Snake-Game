using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        int x;
        int y;
        char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Print();
        }

    }
}
