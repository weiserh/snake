using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public List<Point> SnakeArray { get; set; }
        public Direction direction { get; set; }
        public enum Direction { Right, Left, Up, Down }

        public Snake(Point p)
        {
            SnakeArray = new List<Point>();
            direction = Direction.Right;
            SnakeArray.Add(p);
        }

        public void SnakeMove()
        {
            SnakeArray.RemoveAt(SnakeArray.Count - 1);           
        }
                    
        public Point MoveNext()
        {
            Point head = new Point(SnakeArray[0].Xlocation,SnakeArray[0].Ylocation,'o');
            switch (direction)
            {
                case Direction.Right:
                    head.Xlocation++;
                    break;
                case Direction.Left:
                    head.Xlocation--;
                    break;
                case Direction.Up:
                    head.Ylocation++;
                    break;
                case Direction.Down:
                    head.Ylocation--;
                    break;
            }
            SnakeArray.Insert(0, head);
            return head;
        }
    }
}
