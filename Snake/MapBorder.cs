using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class MapBorder
    {
        List<Point> border = new List<Point>();
        private IPointWriter _writer;

        public MapBorder(int width, int height, char sym, IPointWriter writer)
        {
            _writer = writer;
            for (int x = 0; x < width - 1; x++)
            {
                border.Add(new Point(x, 0, sym, _writer));
            }

            foreach (Point p in border)
            {
                p.Print();
            }
        }
    }
}
