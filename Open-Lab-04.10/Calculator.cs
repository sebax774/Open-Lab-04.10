using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float f = 0;
            foreach (var v in nums)
            {
                f += v;
            }
            return f / nums.Length;
        }
    }
}
