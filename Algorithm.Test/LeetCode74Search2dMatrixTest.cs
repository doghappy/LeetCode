using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode74Search2dMatrixTest
    {
        [TestMethod]
        public void SearchMatrixTest1()
        {
            //var matrix = new int[3, 4]
            //{
            //    { 1, 3, 5, 7 },
            //    { 10, 11, 16, 20 },
            //    { 10, 11, 16, 20 }
            //};
            var matrix = new int[][]
            {
                new[] { 1, 3, 5, 7 },
                new[] { 10, 11, 16, 20 },
                new[] { 23, 30, 34, 60 }
            };
            Assert.IsTrue(LeetCode74Search2dMatrix.SearchMatrix(matrix, 3));
        }

        [TestMethod]
        public void SearchMatrixTest2()
        {
            var matrix = new int[][]
            {
                new[] { 1, 3, 5, 7 },
                new[] { 10, 11, 16, 20 },
                new[] { 23, 30, 34, 60 }
            };
            Assert.IsFalse(LeetCode74Search2dMatrix.SearchMatrix(matrix, 13));
        }
    }
}
