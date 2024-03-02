
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] ans = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = temperatures.Length - 1; i >= 0; i--) {
            while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()]) {
                stack.Pop();
            }

            if (stack.Count == 0) {
                ans[i] = 0;
            } else {
                ans[i] = stack.Peek() - i;
            }

            stack.Push(i);
        }
        return ans;
    }
}