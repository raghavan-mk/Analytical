using System.Collections;
using System.Diagnostics;
using Problems;
using Xunit;

namespace Tests {
    public class AnalyticalTest
    {
        [Theory]
        [InlineData("aaaabbbcca", "[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",1)]")]
        [InlineData("aaaabbbccaa", "[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",2)]")]
        public void FindCharCount_Test(string input, string expected)
        {
            var result = Analytical.CharCount(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(InlineData.MaxProfit), MemberType = typeof(InlineData))]
        public void MaxProfit_Test(int[] prices, long expected)
        {
            var result = Analytical.MaxProfit(prices);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [MemberData(nameof(InlineData.GameOfLife), MemberType = typeof(InlineData))]
        public void GameOfLife_Test(int[][] board, int[] expected)
        {
            var result = Analytical.GameOfLife(board);
            Assert.Equal(expected, result); 
        }
    }
}