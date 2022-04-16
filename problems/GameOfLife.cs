using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems
{
    public class Solution
    {
        private Direction[] _directions;

        public Solution()
        {
            _directions = new Direction[]
            {
                new() {X = -1, Y = -1},
                new() {X = -1, Y = 0},
                new() {X = -1, Y = 1},
                new() {X = 0, Y = -1},
                new() {X = 0, Y = 1},
                new() {X = 1, Y = -1},
                new() {X = 1, Y = 0},
                new() {X = 1, Y = 1}
            };
        }

        public void GameOfLife(int[][] board)
        {
            var matrix = Convert(board);

            Parallel.For(0, matrix.GetLength(0), i =>
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    var current = matrix[i, j];

                    var neighbours = GetNeighbours(matrix, i, j);

                    var live = neighbours.Count(n => n == 1);

                    board[i][j] = current switch
                    {
                        1 when live is 2 or 3 => 1,
                        0 when live == 3 => 1,
                        _ => 0
                    };
                }
            });
        }

        IEnumerable<int> GetNeighbours(int[,] board, int x, int y)
        {
            var n = new int[8];

            for (var i = 0; i < _directions.Length; i++)
            {
                var newX = x + _directions[i].X;
                var newY = y + _directions[i].Y;
                if (newX < 0 || newX >= board.GetLength(0) ||
                    newY < 0 || newY >= board.GetLength(1))
                {
                    continue;
                }

                n[i] = board[newX, newY];
            }

            return n;
        }

        public int[,] Convert(int[][] source)
        {
            int[,] result = new int[source.Length, source[0].Length];

            for (int i = 0; i < source.Length; i++)
            {
                for (int j = 0; j < source[0].Length; j++)
                {
                    result[i, j] = source[i][j];
                }
            }

            return result;
        }

        public struct Direction
        {
            public int X;
            public int Y;
        };
    }
}