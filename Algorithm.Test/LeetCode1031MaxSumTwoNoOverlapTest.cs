using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode1031MaxSumTwoNoOverlapTest
    {
        [TestMethod]
        [DataRow(new[] { 0, 6, 5, 2, 2, 5, 1, 9, 4 }, 1, 2, 20)]
        [DataRow(new[] { 3, 8, 1, 3, 2, 1, 8, 9, 0 }, 3, 2, 29)]
        [DataRow(new[] { 2, 1, 5, 6, 0, 9, 5, 0, 3, 8 }, 4, 3, 31)]
        public void MaxSumTwoNoOverlap(int[] array, int l, int m, int expected)
        {
            var leetCode = new LeetCode1031MaxSumTwoNoOverlap();
            int actual = leetCode.MaxSumTwoNoOverlap(array, l, m);
            Assert.AreEqual(expected, actual);
        }
    }
}
