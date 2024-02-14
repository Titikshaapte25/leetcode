# Daily Temperatures (C#)

## Description:
This C# code solves the "Daily Temperatures" problem, where you're given an array of daily temperatures and need to find the number of days each element needs to wait until a warmer temperature occurs.

## Key Features:
Time Complexity: O(n^2)
Space Complexity: O(n)
Efficiently determines waiting days using nested loops for comparisons.
Handles cases where no warmer temperature is found.

## Usage:
Create a Solution object.
Call the DailyTemperatures(int[] temperatures) method, passing the temperature array.
The method returns an integer array result, where result[i] represents the number of days to wait for a warmer temperature after day i.
Example:

## C#
    int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
    Solution s = new Solution();
    int[] result = s.DailyTemperatures(temperatures);
    Console.WriteLine(string.Join(" ", result)); // Output: 1 1 4 2 1 1 0 0


## Additional Notes:
Consider alternative algorithms for potentially better time complexity (e.g., using a stack).
Adapt the code to handle different input or output formats if needed.

## Test Cases:

The code has been tested with the following test cases:

    Input                                Output
    [73, 74, 75, 71, 69, 72, 76, 73]    [1, 1, 4, 2, 1, 1, 0, 0]
    [30, 40, 50, 60]                    [1, 1, 1, 0]
    [30, 60, 90]                        [1, 1, 0]
