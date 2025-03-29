// https://leetcode.com/problems/longest-common-prefix
// 28-29/03/25
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string answer = "";

        // Shortest Length of all Strings in the array
        int minLength = strs.Min(y=>y.Length); 
        
        // Going through each letter of each word
        for (int i = 0; i < minLength; i++) {
            string temp = "";
            // Adding the letter to temp
            for (int j = 0; j < strs.Length; j++) {
                temp += strs[j][i];
            }
            
            // Checking if all letters are the same
            // if temp = ffff; do nothing;
            // if temp = fffl; return answer;
            for (int k = 0; k < temp.Length; k++) {
                // Prevent indexing errors
                if (k != 0) {
                    if (temp[k] != temp[k-1]) {;
                        return answer;
                    }
                }
            }

            // Adding the letter to the answer
            if (temp != "") {
                answer += temp[0];
            }
        }
        return answer;
    }
}

// Example 1:
// Input: strs = ["flower","flow","flight"]
// Output: "fl"

// Example 2:
// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.
