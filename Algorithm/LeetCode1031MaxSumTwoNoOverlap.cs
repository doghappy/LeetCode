namespace Algorithm
{
    // https://leetcode-cn.com/problems/maximum-sum-of-two-non-overlapping-subarrays/
    public class LeetCode1031MaxSumTwoNoOverlap
    {
        public int MaxSumTwoNoOverlap(int[] A, int L, int M)
        {
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int tempMaxL = 0;
                if (i + L <= A.Length)
                {
                    for (int j = 0; j < L; j++)
                    {
                        tempMaxL += A[i + j];
                    }
                }

                for (int j = 0; j < A.Length; j++)
                {
                    int tempMaxM = 0;
                    if (j < i && j + M <= i)
                    {
                        for (int k = 0; k < M; k++)
                        {
                            tempMaxM += A[j + k];
                        }
                    }
                    else if (j >= i + L && j + M <= A.Length)
                    {
                        for (int k = 0; k < M; k++)
                        {
                            tempMaxM += A[j + k];
                        }
                    }

                    int tempMax = tempMaxL + tempMaxM;
                    if (tempMax > max)
                    {
                        max = tempMax;
                    }
                }
            }
            return max;
        }
    }
}
