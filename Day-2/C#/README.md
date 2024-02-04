# Maximum Profit Calculator (C#)

## Description:

This C# code efficiently calculates the maximum possible profit that can be made by buying and selling a stock at most once, given an array of stock prices.

## Key Features:

Time Complexity: O(n)
Space Complexity: O(1)
Handles fluctuating stock prices
Identifies the optimal buy and sell points
Clear and concise implementation

## How It Works:

Initialization:
Sets variables j, largestProfit, and profit to 1, 0, and 0, respectively.
Iteration:
Iterates through the prices array using two pointers, i and j.
If the current price prices[j] is less than or equal to the previous price prices[i], moves i to j to skip unprofitable periods.
Otherwise, calculates the potential profit profit = prices[j] - prices[i].
Updates largestProfit if the current profit is larger.
Increments j to move to the next price.
Return:
Returns the largestProfit found after iterating through the array.

## Usage:

Create a Solution object.
Call the MaxProfit(int[] prices) method, passing the array of stock prices.
The method returns the maximum possible profit.

## Additional Notes:

The code assumes that only one buy and sell transaction is allowed.
It effectively handles cases where multiple profitable buying and selling opportunities exist.