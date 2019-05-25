using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int Xlocation { get; set; }
        public int Ylocation { get; set; }
        public char Char { get; set; }

        public Point(int x, int y, char c)
        {
            Xlocation = x;
            Ylocation = y;
            Char = c;
        }
    }
}
