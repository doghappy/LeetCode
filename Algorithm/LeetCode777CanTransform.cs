namespace Algorithm
{
    //https://leetcode-cn.com/problems/swap-adjacent-in-lr-string/
    public class LeetCode777CanTransform
    {
        public bool CanTransform(string start, string end)
        {
            if (start.Replace("X", string.Empty) == end.Replace("X", string.Empty))
            {
                int j = 0;
                for (int i = 0; i < start.Length; i++)
                {
                    if (start[i] == 'L')
                    {
                        while (end[j] != 'L')
                        {
                            j++;
                        }
                        if (j > i)
                        {
                            return false;
                        }
                        j++;
                    }
                }
                j = 0;
                for (int i = 0; i < start.Length; i++)
                {
                    if (start[i] == 'R')
                    {
                        while (end[j] != 'R')
                        {
                            j++;
                        }
                        if (j < i)
                        {
                            return false;
                        }
                        j++;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
