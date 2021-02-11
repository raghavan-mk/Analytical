using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Problems;
using Xunit;

namespace Tests {
    public class AnalyticalTest {
        [Theory]
        [InlineData ("aaaabbbcca", "[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",1)]")]
        [InlineData ("aaaabbbccaa", "[(\"a\",4),(\"b\",3),(\"c\",2),(\"a\",2)]")]
        public void FindCharCount_Test (string input, string expected) {
            var result = Analytical.CharCount (input);
            Assert.Equal (expected, result);

        }

        [Theory]
        [ClassData (typeof (InlineDataForMaxProfit))]
        public void MaxProfit_Test (int[] prices, long expected) {

            var result = Analytical.MaxProfit (prices);
            Assert.Equal (expected, result);
        }
    }

    public class InlineDataForMaxProfit : IEnumerable<object[]> {
        public IEnumerator<object[]> GetEnumerator () {
            yield return new object[] { new int[] { 7, 1, 5, 3, 6, 4 }, 5 };
            yield return new object[] {
                File.ReadAllText ("maxprofitinput.txt").Split (',').Select (Int32.Parse).ToArray (), 999
            };
            yield return new object[] { new int[] { 7, 6, 4, 3, 1 }, 0 };
        }

        IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();

    }
}