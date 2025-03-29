// https://leetcode.com/problems/palindrome-number/
// 28/03/2025
public class Solution {
    public bool IsPalindrome(int x) {
        string answer = "";
        string xString = x.ToString();
        int length = Convert.ToInt32(x.ToString().Length);
        
        for (int i = length - 1; i > -1; i--) {
            answer += xString[i].ToString();
        }

        if (answer == x.ToString()) {
            return true;
        } else {
            return false;
        }
    }
}