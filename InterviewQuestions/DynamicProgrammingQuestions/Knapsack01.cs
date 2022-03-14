

namespace DynamicProgrammingQuestions
{
    public class Knapsack01
    {
        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static int KnapSackRec(int W, int[] wt, int[] val,
                            int n, int[,] dp)
        {
            if (n == 0 || W == 0)
            {
                return 0;
            }
            if (dp[n, W] != -1)
            {
                return dp[n, W];
            }
            if (wt[n - 1] > W)
            {
                return dp[n, W] = KnapSackRec(W, wt, val, n - 1, dp);
            }
            else
            {
                return dp[n, W] = Max((val[n - 1] + KnapSackRec(W - wt[n - 1], wt, val, n - 1, dp)), KnapSackRec(W, wt, val, n - 1, dp));
            }
        }
            public int KnapSack(int W, int[] wt, int[] val, int N)
            {
                int[,] dp = new int[N + 1, W + 1];
                for (int i = 0; i < N + 1; i++)
                    for (int j = 0; j < W + 1; j++)
                        dp[i, j] = -1;

                return KnapSackRec(W, wt, val, N, dp);
            }
        }
    }
