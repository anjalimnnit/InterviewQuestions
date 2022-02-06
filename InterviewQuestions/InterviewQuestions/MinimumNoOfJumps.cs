using System;

namespace InterviewQuestions
{
    /* 
     Given an array of integers where each element represents 
    the max number of steps that can be made forward from that element.
    Write a function to return the minimum number of jumps to reach the 
    end of the array (starting from the first element). If an element is 0, 
    then we cannot move through that element. If we can’t reach the end, return -1
    Examples: 

    Input:  arr[] = {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9}
    Output: 3 (1-> 3 -> 8 -> 9)
    Explanation: Jump from 1st element to 
    2nd element as there is only 1 step, 
    now there are three options 5, 8 or 9. 
    If 8 or 9 is chosen then the end node 9 
    can be reached. So 3 jumps are made.
     */
    public class MinimumNoOfJumps
    {
        public int MinJumps(int[] arr)
        {
            int n = arr.Length;
            if (n <= 1)
                return 0;
            if (arr[0] == 0)
                return -1;
            int maxReach = arr[0];
            int step = arr[0];
            int jumpCount = 1;
            for (int i = 1; i < n; i++)
            {
                if (i == n - 1)
                    return jumpCount;
                maxReach = Math.Max(maxReach, i + arr[i]);
                step--;
                if (step == 0)
                {
                    jumpCount++;
                    if (i >= maxReach)
                        return -1;
                    step = maxReach - i;
                }
            }
            return -1;
        }
    }
}


/*
 Complexity Analysis:  

Time complexity: O(n). 
Only one traversal of the array is needed.
Auxiliary Space: O(1). 
There is no space required.
 */