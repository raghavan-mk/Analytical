
using System;
using Xunit;
using Problems;

namespace Tests
{
    public class AnalyticalTest
    {
        [Theory]
        [InlineData("aaaabbbcca","[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",1)]")]
        [InlineData("aaaabbbccaa","[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",2)]")]
        public void FindCharCount_Test(string input, string expected)
        {            
            var result = Analytical.CharCount(input);
            Assert.Equal(expected,result);                    
        }
    }
}
