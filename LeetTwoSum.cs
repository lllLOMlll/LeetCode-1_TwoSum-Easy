using System.Configuration.Assemblies;
using System.Globalization;
using System.Reflection.PortableExecutable;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] functionReturn = new int[2];
        int selectedNumber = 0;
        while (selectedNumber < nums.Length)
        {
            for (int i = selectedNumber + 1; i < nums.Length; i++)
            {
                if (nums[selectedNumber] + nums[i] == target)
                {
                    functionReturn[0] = selectedNumber;
                    functionReturn[1] = i;
                    return functionReturn;
                }
            }
            selectedNumber += 1;
        }

        return functionReturn;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] nums1 = [2, 7, 11, 15];
        int target1 = 9;
        Console.WriteLine(string.Join(", ", s.TwoSum(nums1, target1)));

        int[] nums2 = [3, 2, 4];
        int target2 = 6;
        Console.WriteLine(string.Join(", ", s.TwoSum(nums2, target2)));

        int[] nums3 = [3, 3];
        int target3 = 6;
        Console.WriteLine(string.Join(", ", s.TwoSum(nums3, target3)));
    }
}