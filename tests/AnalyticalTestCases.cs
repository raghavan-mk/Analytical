
using System;
using Xunit;
using Problems;

namespace Tests
{
    public class AnalyticalTest
    {
        [Theory,InlineData("aaaabbbcca")]
        public void FindCharCount_Test(string input)
        {            
            var result = Analytical.CharCount(input);
            Assert.Equal("[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",1)]",result);

        }
    }
}
