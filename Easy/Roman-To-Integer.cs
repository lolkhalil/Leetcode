// https://leetcode.com/problems/roman-to-integer/
// 28/03/2025
public class Solution {
    public int RomanToInt(string s) {
        int answer = 0;
        bool skip = false;

        for (int i = 0; i < s.Length; i++) {
            if (skip) {
                skip = false;
                continue;
            }

            int firstTemp = ReturnNum(s[i]);
            int secondTemp = 0;
            if (i != s.Length - 1) {
                secondTemp = ReturnNum(s[i+1]);
            }

            if (firstTemp < secondTemp) {
                answer += secondTemp - firstTemp;
                skip = true;
            } else {
                answer += firstTemp;
            }
        }

        return answer;
    }

    public static int ReturnNum(char Numeral) {
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