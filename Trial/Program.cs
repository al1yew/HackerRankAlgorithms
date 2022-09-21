using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            //compareTwoLists();

            //diagonalDifference();

            //plusMinus();

            //staircase();

            //miniMaxSum();

            //birthdayCakeCandles();
        }

        private static void birthdayCakeCandles()
        {
            List<int> candles = new List<int> { 3, 1, 2, 3 };

            candles.Sort();

            int maxValue = candles.Max();
            int count = 0;

            foreach (var candle in candles)
            {
                if (candle == maxValue) { count++; }
            }

            Console.WriteLine(count);
        }

        private static void miniMaxSum()
        {
            List<int> arr = new List<int> { 1528964168, 2147483647, 2, 4, 5 };

            long bigsum = 0;
            long smallsum = 0;

            var bigsumarr = arr.OrderBy(x => x).ToList().Take(4);
            var smallsumarr = arr.OrderByDescending(x => x).ToList().Take(4);

            foreach (var item in bigsumarr)
            {
                bigsum += item;
            }
            foreach (var item in smallsumarr)
            {
                smallsum += item;
            }
            Console.WriteLine($"{bigsum} {smallsum}");
        }

        private static void staircase()
        {
            int a = 6;
            string result = "";

            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j < a - i; j++)
                {
                    result += " ";
                }

                for (int j = 0; j < a - (a - i); j++)
                {
                    result += "#";
                }
                Console.WriteLine(result);
                result = "";
            }
        }

        public static void plusMinus()
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -50, -51, 0, 0, 0, -5, -6, -4, -8 };

            var plus = arr.Where(x => x > 0).ToList().Count;
            var minus = arr.Where(x => x < 0).ToList().Count;
            var zero = arr.Where(x => x == 0).ToList().Count;

            Console.WriteLine(((double)plus / (double)arr.Count).ToString("0.000000"));
            Console.WriteLine(((double)minus / (double)arr.Count).ToString("0.000000"));
            Console.WriteLine(((double)zero / (double)arr.Count).ToString("0.000000"));
        }

        public static void diagonalDifference()
        {
            List<List<int>> arr = new List<List<int>>();

            List<int> b = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var cons = int.Parse(Console.ReadLine());
                    b.Add(cons);
                }

                arr.Add(b);
            }

            int sumLeft = 0, sumRight = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sumLeft += arr.ElementAt(i).ElementAt(i);
                sumRight += arr.ElementAt(i).ElementAt(arr.Count - i - 1);
            }

            Console.WriteLine(Math.Abs(sumLeft - sumRight));

            //ne rab

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //int result = Result.diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            //Given a square matrix, calculate the absolute difference between the sums of its diagonals.

            //For example, the square matrix  is shown below:

            //1 2 3
            //4 5 6
            //9 8 9  
            //The left-to-right diagonal = . The right to left diagonal = . Their absolute difference is .

            //Function description

            //Complete the  function in the editor below.

            //diagonalDifference takes the following parameter:

            //int arr[n][m]: an array of integers
            //Return

            //int: the absolute diagonal difference
            //Input Format

            //The first line contains a single integer, , the number of rows and columns in the square matrix .
            //Each of the next  lines describes a row, , and consists of  space-separated integers .

            //Constraints

            //Output Format

            //Return the absolute difference between the sums of the matrix's two diagonals as a single integer.

            //Sample Input

            //3
            //11 2 4
            //4 5 6
            //10 8 -12
            //Sample Output

            //15
            //Explanation

            //The primary diagonal is:

            //11
            //   5
            //     -12
            //Sum across the primary diagonal: 11 + 5 - 12 = 4

            //The secondary diagonal is:

            //     4
            //   5
            //10
            //Sum across the secondary diagonal: 4 + 5 + 10 = 19
            //Difference: |4 - 19| = 15

            //Note: |x| is the absolute value of x

        }

        public static void compareTwoLists()
        {
            List<int> a = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                var cons = int.Parse(Console.ReadLine());
                a.Add(cons);
            }

            List<int> b = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                var cons = int.Parse(Console.ReadLine());
                b.Add(cons);
            }

            int score1 = 0;
            int score2 = 0;
            int j = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[j])
                {
                    score1++;
                }
                else
                {
                    score2++;
                }
                j++;
            }

            List<int> scores = new List<int> { score1, score2 };

            Console.WriteLine(String.Join(", ", scores));
        }
    }
}
