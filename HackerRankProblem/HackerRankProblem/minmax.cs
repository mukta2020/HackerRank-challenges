using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankProblem
{
    public class minmax
    {

        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();

            long s = arr.Sum(x => (long)x);

            Console.Write(s - arr[arr.Count - 1]);
            Console.Write(" ");
            Console.Write(s - arr[0]);

        }
    }
}
