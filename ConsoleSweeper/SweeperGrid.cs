using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        int[,] board = new int[10, 10];
        Random generator = new Random();

        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = 9;

                }
            }

            for (int i = 0; i < 10; i++)
            {
                int y = generator.Next(0, 10);
                int x = generator.Next(0, 10);

                while (board[x, y] == 10)
                {
                    y = generator.Next(0, 10);
                    x = generator.Next(0, 10);

                }

                board[x, y] = 10;
            }

            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    Console.Write(board[x, y]);
                }
                Console.WriteLine(" ");
            }
        }

        public bool checkPosition()
        {
            Console.WriteLine("");

            Console.WriteLine("X value:");
            string ansx = Console.ReadLine();

            Console.WriteLine("Y value:");
            string ansy = Console.ReadLine();

            int coordsx = int.Parse(ansx);
            int coordsy = int.Parse(ansx);

            while (coordsx > 9 && coordsx < 0)
            {
                Console.WriteLine("X value [0-9]:");
                ansx = Console.ReadLine();
            }
        }
    }

}
