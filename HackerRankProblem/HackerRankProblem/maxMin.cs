using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankProblem
{
    public class maxMin1
    {

        public static int maxMin(int k, List<int> arr)
        {
            // sort the list
            arr.Sort();

            int minUnfairness = int.MaxValue;

            // slide window of size k
            for (int i = 0; i <= arr.Count - k; i++)
            {
                int unfairness = arr[i + k - 1] - arr[i];
                if (unfairness < minUnfairness)
                {
                    minUnfairness = unfairness;
                }
            }

            return minUnfairness;

        }

    }
}
