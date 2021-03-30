using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode190ReverseBitsTest
    {
        [TestMethod]
        [DataRow(43261596u, 964176192u)]
        [DataRow(4294967293u, 3221225471u)]
        [DataRow(43261596u, 964176192u)]
        [DataRow(4294967293u, 3221225471u)]
        public void ReverseBitsTest(uint input, uint output)
        {
            uint result = LeetCode190ReverseBits.ReverseBits(input);
            Assert.AreEqual(output, result);
        }
    }
}
