using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Board
    {
        int Width { get; set; }
        int Height { get; set; }
        Char[,] BoardValues { get; set; }

        public Board(int height, int width)
        {
            Height = height;
            Width = width;
            BoardValues = new Char[height, width];

            // update full line
            for (int i = 0; i < width; i++)
            {
                BoardValues[0, i] = '*';
                BoardValues[height - 1, i] = '*';
            }

            // update full column
            for (int i = 1; i < height - 1; i++)
            {
                BoardValues[i, 0] = '*';
                BoardValues[i, width - 1] = '*';
            }

            // update middle
            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    BoardValues[i, j] = ' ';
                }
            }
        }
        public void UpdateBoard(Point point)
        {
            BoardValues[point.Xlocation, point.Ylocation] = point.Char;
        }
        public Char GetValue(int x, int y)
        {
            return BoardValues[x, y];
        }

        public void Print()
        {
            Console.SetCursorPosition(0,0);
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(BoardValues[i, j]);
                    }
                    Console.Write("\n");
                }
        }
    }
}
