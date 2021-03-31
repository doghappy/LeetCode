using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode4FindMedianSortedArraysTest
    {
        [TestMethod]
        [DataRow(new[] { 1, 3 }, new[] { 2 }, 2d)]
        [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 2.5d)]
        public void LengthOfLongestSubstringTest(int[] nums1, int[] nums2, double expected)
        {
            double actual = LeetCode4FindMedianSortedArrays.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, actual);
        }
    }
}
