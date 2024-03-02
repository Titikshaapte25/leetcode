#Daily Temperatures Analysis

This code implements the DailyTemperatures function, which analyzes a list of daily temperatures to determine how many days each element needs to wait until a warmer temperature occurs.

##Problem Statement:

Given an array temperatures representing daily temperatures, return another array ans where ans[i] indicates the number of days to wait after the ith day to encounter a warmer temperature. If no warmer day exists, set ans[i] to 0.

##Approach:

The function utilizes a stack to efficiently find the next warmer temperature for each day. The steps involved are:

##Initialize:
Create an empty stack (stack) to store indices of increasing temperatures.
Initialize an output array (ans) of the same length as temperatures to store waiting days.
Iterate from Right to Left:
Traverse the temperatures array backward (from right to left).

Pop Elements Until Warmer Found:
Within the loop, keep popping elements from the stack as long as the current temperature (temperatures[i]) is greater than or equal to the temperature at the peek of the stack (temperatures[stack.Peek()]). This ensures that only strictly warmer temperatures are considered.

Calculate Waiting Days:
If the stack becomes empty while popping, it means no warmer temperature exists in the future days, so set ans[i] to 0.
Otherwise, the difference between the current index (i) and the index at the top of the stack (stack.Peek()) represents the waiting days, so store this difference in ans[i].

Push Current Index:
After processing the current temperature, push its index (i) onto the stack to potentially help find the next warmer temperature for subsequent days.

Return Result:
Once the loop completes, the ans array contains the waiting days for each day in the input array. Return ans.

##Example:

Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
Output: ans = [1, 1, 4, 2, 1, 1, 0, 0]
Time Complexity: O(N) due to the single pass through the array.
Space Complexity: O(N) because of the stack usage.