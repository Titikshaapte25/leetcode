# Palindrome Checker (C#)

### Description:

This code implements a method to efficiently determine whether a given input string is a palindrome. A palindrome is a word, phrase, or sequence that reads the same backward as forward, ignoring punctuation, spaces, and case.

### Key Features:

Time Complexity: O(n)
Space Complexity: O(n)
Handles mixed-case letters and non-alphanumeric characters
Uses a StringBuilder for efficient string manipulation
How It Works:

### Preprocessing:
Removes spaces and punctuation.
Converts all letters to lowercase.
Palindrome Check:
Iterates through the characters of the preprocessed string, comparing the first and last characters, then the second and second-to-last, and so on.
Returns false as soon as a mismatch is found.
Returns true if all characters match.

### Usage:

Create a Solution object.
Call the IsPalindrome(string) method, passing the string to be checked.
The method returns true if the string is a palindrome, false otherwise.
Example:

### C#
Solution sol = new Solution();
bool result = sol.IsPalindrome("Race a car!");  // Returns true
Use code with caution. Learn more

## Additional Notes:

The code's time complexity is O(n) because it iterates through the string at most twice.
The space complexity is also O(n) due to the use of a StringBuilder to store the preprocessed string.