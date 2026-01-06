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

        public static int birthdayCakeCandles(List<int> candles)
        {

            int s = candles.Max();
            return candles.FindAll(x => x == s).Count();

        }

        public static string timeConversion(string s)
        {
            string last = s.Substring(s.Length - 2);
            string[] p = s.Split(':');
            string ret = "";
            if (last == "AM" && p[0] == "12")
            {
                ret = "00:" + p[1] + ":" + p[2].Substring(0, 2);
            }
            else if (last == "PM" && p[0] != "12")
            {
                ret = Convert.ToInt32(p[0]) + 12 + ":" + p[1] + ":" + p[2].Substring(0, 2);
            }
            else
            {
                ret = p[0] + ":" + p[1] + ":" + p[2].Substring(0, 2);
            }

            return ret;

        }
    }
}
