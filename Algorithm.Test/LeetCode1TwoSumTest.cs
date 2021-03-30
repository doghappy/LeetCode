using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode1TwoSumTest
    {
        [TestMethod]
        [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var result = LeetCode1TwoSum.TwoSum(nums, target);
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
        }
    }
}
