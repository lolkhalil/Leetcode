// https://leetcode.com/problems/roman-to-integer/
// 28/03/2025
public class Solution {
    public int RomanToInt(string s) {
        int answer = 0;
        bool skip = false;

        for (int i = 0; i < s.Length; i++) {
            // Skips the Numeral since it's like IV/CM etc 
            if (skip) {
                skip = false;
                continue;
            }

            // Getting the Number based on the Numeral
            int firstTemp = ReturnNum(s[i]);
            int secondTemp = 0;
            
            // Prevent indexing errors
            if (i != s.Length - 1) {
                // Getting the next letter along to check for a numeral like IV/CM
                secondTemp = ReturnNum(s[i+1]);
            }

            // Means it's a numeral like IV/CM etc
            if (firstTemp < secondTemp) {
                // Subtraction rule that was mentioned in the desc
                answer += secondTemp - firstTemp;
                skip = true;
            } else {
                answer += firstTemp;
            }
        }

        return answer;
    }

    // Needed a solution for this part
    public int ReturnNum(char Numeral) {
        switch (Numeral) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}

// Example 1:
// Input: s = "III"
// Output: 3
// Explanation: III = 3.

// Example 2:
// Input: s = "LVIII"
// Output: 58
// Explanation: L = 50, V= 5, III = 3.

// Example 3:
// Input: s = "MCMXCIV"
// Output: 1994
// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
