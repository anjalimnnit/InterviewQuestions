

namespace DynamicProgrammingQuestions
{
    public class Knapsack01
    {
        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public int KnapSack(int w, int[] wt,
                        int[] val, int n)
        {
            if (w == 0 || n == 0)
            {
                return 0;
            }
            return wt[n - 1] > w
                ? KnapSack(w, wt, val, n - 1)
                : Max(val[n - 1] + KnapSack(w - wt[n - 1], wt, val, n - 1), KnapSack(w, wt, val, n - 1));
        }

        /*
 Complexity Analysis: 

Time Complexity: O(2n). 
As there are redundant subproblems.
Auxiliary Space :O(1). 
As no extra data structure has been used for storing values.
         */
    }
}
