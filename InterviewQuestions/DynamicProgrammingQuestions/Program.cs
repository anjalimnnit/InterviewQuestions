using System;

namespace DynamicProgrammingQuestions
{
    class Program
    {
        static void Main()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            Knapsack01 ks = new Knapsack01();
            Console.WriteLine(ks.KnapSack(W, wt, val, n));
            int[] array = new int[5] { -2, 1, 3, -4, 5 };
            Console.WriteLine($"Maximum adjacent array sum is:{ MaxNonAdjacentArraySum.MaxSum(array, array.Length)}");
        }
    }
}
