using System;


public class Solution
{
    public  int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }

            }
            return Array.Empty<int>();
        }
        return Array.Empty<int>();
    }

    // Entry point of the program
    class Program
    {
        static void Main()
        {
            Solution solution = new();
            

            int[] result = solution.TwoSum(new int[] {2,7,11,15},9);

            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
