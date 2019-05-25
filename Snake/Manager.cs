using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Manager
    {
        int scroe = 0;
        Snake snake;
        Board board;
        Point food; int x; int y;

        public void NewGame()
        {
            Console.WindowHeight = 200;
            Console.WindowWidth = 200;
            Console.SetWindowSize(150,150);
            x = 50; y = 100;
            board = new Board(x, y);
            Point snakeHead = new Point(30, 30, 'o');
            snake = new Snake(snakeHead);
            board.UpdateBoard(snakeHead);
            food = NewFood(x, y);
        }

        public void RunGame()
        {
            do
            {
                board.Print();
                System.Threading.Thread.Sleep(100);
            }
            while (NextStep());
        }

        public void GameOver() { }
        public int Score { get; set; }

        public bool NextStep()
        {
            Point nextPoint = snake.MoveNext();
            Char boardChar = board.GetValue(nextPoint.Xlocation, nextPoint.Ylocation);

            if (boardChar == 'o' || boardChar == '*')
            {
                GameOver();
                return false;
            }
            else
            {
                board.UpdateBoard(nextPoint);
                if (boardChar == ' ')
                {
                    Point space = new Point(snake.SnakeArray[snake.SnakeArray.Count - 1].Xlocation, snake.SnakeArray[snake.SnakeArray.Count - 1].Ylocation, ' ');
                    board.UpdateBoard(space);
                    snake.SnakeMove();
                }
                if (boardChar == '+')
                {
                    scroe++;
                }
                return true;
            }
        }




        public Point NewFood(int xmax, int ymax)
        {
            Random random = new Random();
            Point food;
            Char value;
            int x;
            int y;
            do
            {
                x = random.Next(0, xmax);
                y = random.Next(0, ymax);
                value = board.GetValue(x, y);
            } while (value != ' ');

            food = new Point(x, y, '+');
            board.UpdateBoard(food);
            return food;
        }
    }
}
