# Integer Palindrome Checker (C++)

This C++ code implements an efficient algorithm to determine whether a given integer is a palindrome. A palindrome is a number that reads the same backward as forward, e.g., 121, 1221, or 1001.

## Key Features:

- Handles positive and negative integers.
- Handles integer overflow gracefully using `long int` for intermediate calculations.
- Efficiently reverses digits to check for palindrome condition.
- Includes unit test cases for comprehensive testing.

## How It Works:

1. **Input Validation:**
   - The `isPalindrome` function checks if the input `x` is negative. If so, it returns `false` as negative integers cannot be palindromes.
2. **Reverse Digits:**
   - The function creates two variables: `org` to store the original `x` and `rev` to store the reversed number.
   - It uses a `while` loop to iterate through the digits of `org`:
     - In each iteration, it calculates the remainder of `org` divided by 10 and adds it to the leftmost position of `rev` (using `rev = (10 * rev) + (org % 10)`) to build the reversed number.
     - It divides `org` by 10 to remove the processed digit.
3. **Palindrome Check:**
   - The function compares the original number (`x`) with the reversed number (`rev`). If they are equal, it returns `true`, indicating that `x` is a palindrome. Otherwise, it returns `false`.

## Usage:

1. Clone or download the repository.
2. Build the code using your preferred C++ compiler.
3. Run the executable with no arguments to execute the test cases.

## Test Cases:

The code includes a `runTestCases` function that executes several test cases with expected outputs: try with this

```c++
std::vector<int> testCases = {
    {1221},
    {10},
    {-121},
    {123454321}, // Large palindrome
    {1000000001} // Integer overflow
};
