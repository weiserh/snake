using System;
using System.Collections.Generic;
using System.Threading;


namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.NewGame();
            manager.RunGame();

        }
    }
}
