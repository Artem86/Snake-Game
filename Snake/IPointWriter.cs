using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    interface IPointWriter
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        void Write(Char c);
        void Write(String s);
    }
}
