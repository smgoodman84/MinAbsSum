using System;
using System.Linq;

namespace MinAbsSum
{
    public class Solution
    {
        // https://codility.com/programmers/task/min_abs_sum/

        public int solution(int[] A)
        {
            var ordered = A.OrderByDescending(Math.Abs);

            var sum = 0;
            foreach (var e in ordered)
            {
                var multiplier = sum > 0 == e > 0 ? -1 : 1;
                sum += e * multiplier;
            }

            return sum;
        }
    }
}
