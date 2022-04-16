using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problems
{
    public static class Analytical
    {
        //input "aaabbcca" 
        //output "[("a",3),("b",2),("c",2),("a",1)]
        public static string CharCount(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                int count = 0;

                StringBuilder charCountSet = new StringBuilder();
                charCountSet.Append("[");

                for (int i = 0; i < input.Length;)
                {
                    var curr = input[i];
                    while (i < input.Length && curr == input[i])
                    {
                        i++;
                        count++;
                    }

                    charCountSet.Append($"(\"{curr}\",{count}),");
                    count = 0;
                }

                charCountSet.Length--; //remove trailing comma
                charCountSet.Append("]");
                return charCountSet.ToString();
            }

            throw new Exception("Input is null or empty");
        }

        //Input: prices = [7,1,5,3,6,4]
        // Output: 5
        // Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        // Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        public static int MaxProfit(int[] prices)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int maxPrice = 0;
            int minPrice = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                else if (maxPrice < prices[i] - minPrice)
                    maxPrice = prices[i] - minPrice;
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            return maxPrice;
        }

        // https://leetcode.com/problems/game-of-life/
        public static int[] GameOfLife(int[][] board)
        {
            new Solution().GameOfLife(board);
            return board.SelectMany(a => a).ToArray();
        }
    }
}