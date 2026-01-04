using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankProblem
{
    public class diagonalDifference
    {

        public static int DiagonalDifference(int[][] arr)
        {
            int n = arr.Length;
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i][i];
                secondaryDiagonalSum += arr[i][n - i - 1];
            }
            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }

        public static int diagonalDifferenceMy(List<List<int>> arr)
        {
            int sum1 = 0;
            int sum2 = 0;
            int i = -1; int j = -1;
            for (int r = 0; r < arr.Count; r++)
            {
                List<int> a = arr[r];
                for (int c = 0; c < a.Count; c++)
                {
                    if (r == c)
                    {
                        sum1 += arr[r][c];
                    }
                    if (r == 0 && c == arr.Count - 1)
                    {
                        i = c; j = 0;
                        sum2 += arr[j][i];
                        j++; i--;
                    }
                    else if (i == c && j == r)
                    {
                        sum2 += arr[j][i];
                        j++; i--;
                    }
                }
            }
            return Math.Abs(sum1 - sum2);

        }

    }
}
