using System;

namespace DynamicProgrammingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            Knapsack01 ks = new Knapsack01();
            Console.WriteLine(ks.KnapSack(W, wt, val, n));
        }
    }
}
