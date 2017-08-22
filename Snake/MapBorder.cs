using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class MapBorder
    {
        List<Point> border = new List<Point>();

        public MapBorder(int width, int height, char sym)
        {
            for (int x = 0; x < width - 1; x++)
            {
                border.Add(new Point(x, 0, sym));
            }

            foreach (Point p in border)
            {
                p.Print();
            }
        }
    }
}
