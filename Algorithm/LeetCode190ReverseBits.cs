namespace Algorithm
{
    //https://leetcode-cn.com/problems/reverse-bits/
    public class LeetCode190ReverseBits
    {
        public static uint ReverseBits(uint n)
        {
            uint result = 0;
            int i = 32;
            while (i-- > 0)
            {
                result <<= 1;
                result += n & 1;
                n >>= 1;
            }
            return result;
        }

        /* 初始值
         * n: 00000010100101000001111010011100
         * result: 0
         * 
         * 第 1 步
         * result: 0
         * result: 0
         * n: 0000001010010100000111101001110
         * 
         * 第 2 步
         * result: 0
         * result: 0
         * n: 000000101001010000011110100111
         * 
         * 第 3 步
         * result: 0
         * result: 1
         * n: 00000010100101000001111010011
         * 
         * 第 4 步
         * result: 10
         * result: 11
         * n: 0000001010010100000111101001
         * 
         * 第 5 步
         * result: 110
         * result: 111
         * n: 000000101001010000011110100
         * 
         * 第 6 步
         * result: 1110
         * result: 1110
         * n: 00000010100101000001111010
         * 
         * 第 7 步
         * result: 11100
         * result: 11100
         * n: 0000001010010100000111101
         * 
         * 第 8 步
         * result: 111000
         * result: 111001
         * n: 000000101001010000011110
         * 
         * 第 9 步
         * result: 1110000
         * result: 1110010
         * n: 00000010100101000001111
         * 
         * 第 10 步
         * result: 11100100
         * result: 11100101
         * n: 0000001010010100000111
         * 
         * ...
         * 
         * 
         */
    }
}
