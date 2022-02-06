using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    /*
    Given the arrival and departure times of all trains that reach a railway station, the task is to find the minimum number of platforms required for the railway station so that no train waits. 
We are given two arrays that represent the arrival and departure times of trains that stop.

Examples: 

Input: arr[] = {9:00, 9:40, 9:50, 11:00, 15:00, 18:00} 
dep[] = {9:10, 12:00, 11:20, 11:30, 19:00, 20:00} 
Output: 3 
Explanation: There are at-most three trains at a time (time between 9:40 to 12:00)

Input: arr[] = {9:00, 9:40} 
dep[] = {9:10, 12:00} 
Output: 1 
Explanation: Only one platform is needed. 
    */
    class MinimumNoOfPlatforms
    {
        public int FindPlatform(int[] arr, int[] dep, int n)
        {
            // Sort arrival and departure arrays
            Array.Sort(arr);
            Array.Sort(dep);

            int minPlatform = 1, totalPlatformRequired = 1;
            int i = 1, j = 0;

            while (i < n && j < n)
            {
                if (arr[i] <= dep[j])
                {
                    minPlatform++;
                    i++;
                }
                else if (arr[i] > dep[j])
                {
                    minPlatform--;
                    j++;
                }

                if (minPlatform > totalPlatformRequired)
                    totalPlatformRequired = minPlatform;
            }

            return totalPlatformRequired;
        }
    }

}
