namespace Algorithm
{
    //https://leetcode-cn.com/problems/search-a-2d-matrix/
    public class LeetCode74Search2dMatrix
    {
        /*
        编写一个高效的算法来判断 m x n 矩阵中，是否存在一个目标值。该矩阵具有如下特性：
        - 每行中的整数从左到右按升序排列。
        - 每行的第一个整数大于前一行的最后一个整数。
        */
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            //var matrix = new int[][]
            //{
            //    new[] { 1, 3, 5, 7 },
            //    new[] { 10, 11, 16, 20 },
            //    new[] { 23, 30, 34, 60 }
            //};
            int begin = 0;
            int mid = 0;
            int len1 = matrix.Length;
            int len2 = matrix[0].Length;
            int end = len1 * len2 - 1;
            while (begin < end)
            {
                mid = (begin + end) / 2;
                if (matrix[mid / len2][mid % len2] < target)
                {
                    begin = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return matrix[begin / len2][begin % len2] == target;
        }
    }
}
