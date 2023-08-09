using System.Collections.Generic;

namespace Lib.ProblemSolving.Test01.Challenge3;

public static class Challenge3
{
    public static int FindLessCostPath(int[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        int[,] cost = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                cost[i, j] = int.MaxValue;
            }
        }

        cost[0, 0] = board[0][0];

        int[] dx = { -1, 1, 0, 0 }; // Possible moves: up, down, left, right
        int[] dy = { 0, 0, -1, 1 };

        // Priority queue to store cells with their associated cost
        PriorityQueue<(int, int, int)> pq = new PriorityQueue<(int, int, int)>();
        pq.Enqueue((0, 0, cost[0, 0]));

        while (pq.Count > 0)
        {
            var (x, y, c) = pq.Dequeue();

            if (c > cost[x, y])
                continue;

            for (int i = 0; i < 4; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
                {
                    int newCost = c + board[newX][newY];

                    if (newCost < cost[newX, newY])
                    {
                        cost[newX, newY] = newCost;
                        pq.Enqueue((newX, newY, newCost));
                    }
                }
            }
        }

        return cost[rows - 1, cols - 1] - board[rows - 1][cols - 1];
    }
}