# Single Number Finder (C#)

## Description:

This C# code implements a solution to efficiently find the single number that appears only once in an array where all other elements appear exactly twice. It utilizes the XOR (exclusive or) bitwise operation to achieve this.

## Key Features:

Time Complexity: O(n)
Space Complexity: O(1)
Clear and concise code with comments
Built-in test cases for validation

## How It Works:

XOR Approach:
The XOR operation has the property that a number XOR'ed with itself results in 0.
By XOR'ing all elements in the array, the duplicate numbers cancel each other out, leaving only the single number.

## Usage:

Compile the code using a C# compiler.
Execute the compiled program.
The output will display the results of the test cases.


## Test Cases:

[1] → Result: 1
[4, 1, 2, 1, 2] → Result: 4
[3, 3, 4, 5, 4] → Result: 5

## Additional Notes:

The XOR approach is a memory-efficient and elegant solution for this problem.
Consider exploring alternative approaches like sorting or using a hash table for different use cases.