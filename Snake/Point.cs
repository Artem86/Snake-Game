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
        private IPointWriter _writer;

        public Point(int _x, int _y, char _sym, IPointWriter writer)
        {
            x = _x;
            y = _y;
            sym = _sym;
            _writer = writer;
        }

        public void Print()
        {
            _writer.PositionX = x;
            _writer.PositionY = y;
            _writer.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Print();
        }

    }
}
