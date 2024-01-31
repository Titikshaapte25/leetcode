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