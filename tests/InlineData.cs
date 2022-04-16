using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tests
{
    public class InlineData
    {
        public static IEnumerable<object[]> MaxProfit()
        {
            yield return new object[] {new int[] {7, 1, 5, 3, 6, 4}, 5};
            yield return new object[]
            {
                File.ReadAllText("maxprofitinput.txt")
                    .Split(',')
                    .Select(Int32.Parse)
                    .ToArray(),
                999
            };
            yield return new object[] {new int[] {7, 6, 4, 3, 1}, 0};
        }

        public static IEnumerable<object[]> GameOfLife()
        {
            yield return new object[]
            {
                new int[][]
                {
                    new[] {0, 1, 0},
                    new[] {0, 0, 1},
                    new[] {1, 1, 1},
                    new[] {0, 0, 0}
                },
                new int[]
                {
                    0, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1, 0
                }
            };
            yield return new object[]
            {
                new int[][]
                {
                    new[] {1, 1},
                    new[] {1, 0}
                },
                new int[] {1, 1, 1, 1}
            };
        }
    }
}