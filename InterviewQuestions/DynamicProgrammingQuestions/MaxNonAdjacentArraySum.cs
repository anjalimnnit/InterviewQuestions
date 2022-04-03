using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgrammingQuestions
{
    class MaxNonAdjacentArraySum
    {
        public static int MaxSum(int[] arr, int n)
        {
            int[] maxIncludedTillThisElement = new int[n];
            maxIncludedTillThisElement[0] = arr[0];
            int[] maxExcludedTillThisElement = new int[n];
            maxExcludedTillThisElement[0] = 0;
            int maxGlobal = arr[0];
            for(int i =1;i<n;i++)
            {
                maxIncludedTillThisElement[i] = Math.Max(arr[i], maxExcludedTillThisElement[i - 1] + arr[i]);
                maxExcludedTillThisElement[i] = Math.Max(maxIncludedTillThisElement[i - 1], maxExcludedTillThisElement[i - 1]);
            }
            int max = Math.Max(maxIncludedTillThisElement[n - 1], maxExcludedTillThisElement[n - 1]);
            return maxGlobal < max ? max : maxGlobal;
        }
    }
}
