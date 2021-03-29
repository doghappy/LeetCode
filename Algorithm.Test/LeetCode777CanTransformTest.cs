using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode777CanTransformTest
    {
        [TestMethod]
        [DataRow("RXXLRXRXL", "XRLXXRRLX", true)]
        [DataRow("LXXLXRLXXL", "XLLXRXLXLX", false)]
        [DataRow("RXR", "XXR", false)]
        [DataRow("XXXXXLXXXX", "LXXXXXXXXX", true)]
        [DataRow("XXXLXXXXXX", "XXXLXXXXXX", true)]
        public void MaxSumTwoNoOverlap(string start, string end, bool expected)
        {
            var leetCode = new LeetCode777CanTransform();
            bool actual = leetCode.CanTransform(start, end);
            Assert.AreEqual(expected, actual);
        }
    }
}
