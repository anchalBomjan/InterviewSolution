//This method is bruteforce approached to solved  the problems which have time complexity is O(n)^2


//using System;
//public class Solution
//{
//    public  int[] TwoSum(int[] nums, int target)
//    {
//        //time Complexity is O(n)^2
//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    return new int[] { i, j };
//                }

//            }

//        }
//        return Array.Empty<int>();
//    }

//    // Entry point of the program
//    class Program
//    {
//        static void Main()
//        {
//            Solution solution = new();


//            int[] result = solution.TwoSum(new int[] {2,7,11,15},9);

//            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
//        }
//    }
//}
public class Solution
{
    public int[] TwoSum(int[] nums, int targets)
    {
        //Dictionary is used to store the numbers and  their indices
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = targets - nums[i];
            //checking wheather the element(complement) is avaiable or not in ArrayList(Dictionary)
            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }
            //other wise loops will run untill its lenghts
            numToIndex[nums[i]] = i;
        }
        return Array.Empty<int>();

    }
}
class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 18);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }
}