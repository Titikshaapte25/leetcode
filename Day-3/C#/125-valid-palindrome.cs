//O(n) Time Complexity

using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		Solution sol = new Solution();
		bool result = sol.IsPalindrome(" Race ae car !!!");
		Console.WriteLine(result);
	}
}

public class Solution {
    public bool IsPalindrome(string s) {
        int count = 0;
        int strLength = s.Length;
        StringBuilder sb = new StringBuilder(strLength);
        foreach (char c in s)
        {
            if((c>='0' && c<='9') || (c>='a' && c<='z'))
            {
                sb.Append(c);
            }
            else if(c>='A' && c<='Z')
            {
                sb.Append(char.ToLower(c));
            }
            else if(c == ' ')
            {
                count ++;
            }
        }
        if(count == strLength)
        {
            return true;
        }
        string newString = sb.ToString();
		int j = newString.Length-1;
        for (int i =0; (i < (newString.Length/2) && j>i) ; i++)
		{  
			if(newString[i] != newString[j])
            {
                return false;
            }
            else{
                j--;
            }
        }
        return true;
    }
}