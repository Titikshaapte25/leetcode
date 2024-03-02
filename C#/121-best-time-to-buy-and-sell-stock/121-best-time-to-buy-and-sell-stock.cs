using System;				
public class Program
{
	public static void Main()
	{
		Solution s = new Solution();
		int result = s.MaxProfit(new int[] {1,2,4,2,5,7,2,4,9,0,9});
		Console.WriteLine(result);	//result will be 9
	}
}

public class Solution {
    public int MaxProfit(int[] prices) {
        int j=1, largestProfit =0,profit =0;
        for (int i =0;  j<prices.Length;)
        {
            if(prices[i]>=prices[j])
            {
                i=j;
            }
            else
            {
                profit = prices[j]-prices[i];   
                if (profit>largestProfit)
                {
                   largestProfit = profit;
                }
            }
            j++;
        }
        return largestProfit;
    }
}