using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class ConsolePointWriter : IPointWriter
    {
        private int _x;
        private int _y;

        public int PositionX {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int PositionY
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public void Write(char c)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(c);
        }

        public void Write(string s)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(s);
        }
    }
}
