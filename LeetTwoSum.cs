using System;
class LeetTwoSum 
{
    public class Solution {
        public int[]? TwoSum(int[] nums, int target) {
            int[] arrayWithResults = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
       
                    if (nums[i] + nums[j] == target)
                    {
                        arrayWithResults[0] = i;
                        arrayWithResults[1] = j;
                        return arrayWithResults;                        
                    }  
                }
            }
            return null;
        }
    }
    

    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] nums1 = [1,3,4,9];
        int target1 = 4;
        int[] result = s.TwoSum(nums1, target1);
        
        Console.WriteLine(string.Join(", ", result));
  




    }
}

