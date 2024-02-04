using System;

public class Program
{
    public static void Main()
    {
        int[][] testCases = new int[][]
        {
            new int[] { 1 },
            new int[] { 4, 1, 2, 1, 2 },
            new int[] { 3, 3, 4, 5, 4 }
        };

        RunTestCases(testCases);
    }

    public static void RunTestCases(int[][] testCases)
    {
        Solution s = new Solution();

        for (int i = 0; i < testCases.Length; i++)
        {
            int result = s.SingleNumber(testCases[i]);
            Console.WriteLine("Test Case {"+ (i+1) +"} Result: " + result);
        }
    }
}
public class Solution{
	public int SingleNumber(int[] nums)
	{	
		if(nums.Length == 1)
		{
			return nums[0];
		}
		
		int answer = nums[0];
        for(int i=1; i<nums.Length; i++)
		{
            answer ^= nums[i];		//2 ^ 2 = 0
        }	
		return answer;
	}
}