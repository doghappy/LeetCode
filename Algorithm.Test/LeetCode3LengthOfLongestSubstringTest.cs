using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode3LengthOfLongestSubstringTest
    {
        [TestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow("", 0)]
        [DataRow(" ", 1)]
        [DataRow("我就是我", 3)]
        public void LengthOfLongestSubstringTest(string s, int expected)
        {
            int actual = LeetCode3LengthOfLongestSubstring.LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow("", 0)]
        [DataRow(" ", 1)]
        //[DataRow("我就是我", 3)]
        public void LengthOfLongestSubstring2Test(string s, int expected)
        {
            int actual = LeetCode3LengthOfLongestSubstring.LengthOfLongestSubstring2(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
