using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Test
{
    [TestClass]
    public class LeetCode2AddTwoNumbersTest
    {
        [TestMethod]
        public void TwoSumTest1()
        {
            var l1 = new LeetCode2AddTwoNumbers.ListNode(2);
            l1.next = new LeetCode2AddTwoNumbers.ListNode(4);
            l1.next.next = new LeetCode2AddTwoNumbers.ListNode(3);

            var l2 = new LeetCode2AddTwoNumbers.ListNode(5);
            l2.next = new LeetCode2AddTwoNumbers.ListNode(6);
            l2.next.next = new LeetCode2AddTwoNumbers.ListNode(4);

            var result = LeetCode2AddTwoNumbers.AddTwoNumbers(l1, l2);
            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
            Assert.IsNull(result.next.next.next);
        }

        [TestMethod]
        public void TwoSumTest2()
        {
            var l1 = new LeetCode2AddTwoNumbers.ListNode(9);
            l1.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l1.next.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l1.next.next.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l1.next.next.next.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l1.next.next.next.next.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l1.next.next.next.next.next.next = new LeetCode2AddTwoNumbers.ListNode(9);

            var l2 = new LeetCode2AddTwoNumbers.ListNode(9);
            l2.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l2.next.next = new LeetCode2AddTwoNumbers.ListNode(9);
            l2.next.next.next = new LeetCode2AddTwoNumbers.ListNode(9);

            var result = LeetCode2AddTwoNumbers.AddTwoNumbers(l1, l2);
            Assert.AreEqual(8, result.val);
            Assert.AreEqual(9, result.next.val);
            Assert.AreEqual(9, result.next.next.val);
            Assert.AreEqual(9, result.next.next.next.val);
            Assert.AreEqual(0, result.next.next.next.next.val);
            Assert.AreEqual(0, result.next.next.next.next.next.val);
            Assert.AreEqual(0, result.next.next.next.next.next.next.val);
            Assert.AreEqual(1, result.next.next.next.next.next.next.next.val);
            Assert.IsNull(result.next.next.next.next.next.next.next.next);
        }
    }
}
