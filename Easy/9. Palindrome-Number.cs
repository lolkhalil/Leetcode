// https://leetcode.com/problems/palindrome-number/
// 28/03/2025
public class Solution {
    public bool IsPalindrome(int x) {
        string answer = "";
        string xString = x.ToString();
        int length = Convert.ToInt32(xString.Length);
        
        // Reversing the string
        for (int i = length - 1; i > -1; i--) {
            answer += xString[i].ToString();
        }

        if (answer == xString) {
            return true;
        } else {
            return false;
        }
    }
}

// Example 1:
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.

// Example 2:
// Input: x = -121
// Output: false
// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

// Example 3:
// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
