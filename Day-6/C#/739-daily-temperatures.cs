using System;
					
public class Program
{
	public static void Main()
	{
		int[][] testCases =  new int [][]
		{
			new int[] {73,74,75,71,69,72,76,73},
			new int[] {30,40,50,60},
			new int[] {30,60,90}
		};
		
		RunTestCases(testCases);
	}
	public static void RunTestCases(int[][] testCases)
	{
		Solution s = new Solution();
		for (int i=0 ; i<testCases.Length ; i++)
		{
			int[] result = s.DailyTemperatures(testCases[i]);
			Console.WriteLine(string.Join(" ",result));
		}
	}
}

public class Solution {
  public int[] DailyTemperatures(int[] temperatures) {
    int i, j;
    int length = temperatures.Length;
    int[] result = new int[length];

    for (i = 0; i < length; i++) 
	{
      j = i + 1;
      while (j < length && temperatures[i] >= temperatures[j]) {
        j++;
      }
      if (j < length) {
        result[i] = j - i;
      } else {
        result[i] = 0;
      }
    }
    return result;
  }
}