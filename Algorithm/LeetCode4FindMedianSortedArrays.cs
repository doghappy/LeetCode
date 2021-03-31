using System;

namespace Algorithm
{
    //https://leetcode-cn.com/problems/median-of-two-sorted-arrays/
    public class LeetCode4FindMedianSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int totalLength = nums1.Length + nums2.Length;
            int a = (totalLength - 1) / 2;
            int b = totalLength / 2;
            int v1 = Find(nums1, nums2, 0, 0, a);
            int v2 = Find(nums1, nums2, 0, 0, b);
            return (v1 + v2) * 1d / 2;
        }

        private static int Find(int[] nums1, int[] nums2, int i, int j, int c)
        {
            if (i >= nums1.Length)
            {
                return nums2[j + c];
            }
            if (j >= nums2.Length)
            {
                return nums1[i + c];
            }
            if (c == 0)
            {
               return Math.Min(nums1[i], nums2[j]);
            }
            else if (nums1[i] > nums2[j])
            {
                return Find(nums1, nums2, i, ++j, --c);
            }
            else
            {
                return Find(nums1, nums2, ++i, j, --c);
            }
        }
    }
}
