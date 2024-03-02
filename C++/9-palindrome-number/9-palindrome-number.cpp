#include <iostream>
#include <vector>

class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0) {
            return false;
        }
        long int org = x, rev = 0;
        while (org > 0) {
            rev = (10 * rev) + (org % 10);
            org /= 10;
        }
        return (rev == x);
    }
};

void runTestCases (std::vector<int>& testCases)
{
    Solution s;
    
    for(int i=0 ; i< testCases.size() ; i++)
    {
        bool result = s.isPalindrome(testCases[i]);
        std::cout << "Test case " << (i+1) <<" result : " << result << '\n';
    }
}

int main() {
    
    std::vector<int> testCases = {
        {1221},
        {10},
        {-121}
    };
    
    runTestCases(testCases);
    
    return 0;
}