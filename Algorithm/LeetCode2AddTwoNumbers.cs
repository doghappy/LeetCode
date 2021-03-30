namespace Algorithm
{
    //https://leetcode-cn.com/problems/add-two-numbers/
    public class LeetCode2AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }


        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = new ListNode();
            var c1 = l1;
            var c2 = l2;
            var node = root;
            while (true)
            {
                int val = node.val;
                if (c1 != null)
                    val += c1.val;
                if (c2 != null)
                    val += c2.val;
                if (val > 9)
                {
                    node.val = val - 10;
                    node.next = new ListNode(1);
                }
                else
                {
                    node.val = val;
                }
                if (c1 != null)
                    c1 = c1.next;
                if (c2 != null)
                    c2 = c2.next;
                if (c1 == null && c2 == null)
                {
                    break;
                }
                else
                {
                    if (node.next == null)
                    {
                        node.next = new ListNode();
                    }
                    node = node.next;
                }
            }
            return root;
        }
    }
}
