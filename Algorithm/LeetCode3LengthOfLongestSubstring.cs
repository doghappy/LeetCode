using System;

namespace Algorithm
{
    //https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/
    public class LeetCode3LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    bool exsits = false;
                    for (int k = i; k < j; k++)
                    {
                        exsits = s[k] == s[j];
                        if (exsits) break;
                    }
                    if (exsits)
                    {
                        break;
                    }
                    else
                    {
                        len++;
                    }
                }
                if (len > max)
                {
                    max = len;
                }
            }
            return max;
        }

        // 网友的高级算法，看半天还不能理解
        // 缺点是如果字符串中包含非 ASCII 码就失效了
        public static int LengthOfLongestSubstring2(string s)
        {
            //abcabcbb
            // 记录字符上一次出现的位置
            int[] arr = new int[128];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }

            int res = 0;
            // 窗口开始位置
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i];
                //start = Math.Max(start, arr[index]);
                //因为 arr[index] 代表上一次出现的位置，但是字符串内字符不能重复，所以要从上一次出现位置的下一个位置开始
                start = Math.Max(start, arr[index] + 1);
                res = Math.Max(res, i - start + 1);
                //arr[index] = i + 1;
                arr[index] = i;
            }
            return res;
        }
    }
}
