using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        int[,] board = new int[10, 10];
        Random r1 = new Random();

        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = 9;

                }
            }
            for (int x > 10)
            {

            }
        }
    }

}
