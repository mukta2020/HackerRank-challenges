using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HackerRankProblem
{
    public class staircases
    {
        public static void piramid3(int row)
        {
            /*
              1
             2 3
            4 5 6
           7 8 9 10
            
             */
            int space = row - 1;
            int c = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int s = 0; s < space; s++)
                {
                    Console.Write(0 + " ");
                }
                space--;

                for (int j = 0; j < i; j++)
                {
                    Console.Write(c++ + " ");
                    Console.Write(0 + " ");
                }
                Console.WriteLine();
            }
        }

        public static void staircase(int n)
        {            

            for (int i = 1; i <= n; i++)
            {
                // print spaces
                Console.Write(new string(' ', n - i));

                // print #
                Console.WriteLine(new string('#', i));
            }


        }

       


    }
}
