// https://leetcode.com/problems/longest-common-prefix
// 28-29/03/25
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string answer = "";
        string temp = "";

        // shortest length of all strs in the array
        int minLength = strs.Min(y=>y.Length); 
        
        for (int i = 0; i < minLength; i++) {
            temp = "";
            for (int j = 0; j < strs.Length; j++) {
                temp += strs[j][i];
            }
            
            // checks if all letters are the same
            // temp = ffff
            // temp = fffl; return answer;
            for (int k = 0; k < temp.Length; k++) {
                if (k != 0) {
                    if (temp[k] != temp[k-1]) {;
                        return answer;
                    }
                }
            }

            if (temp != "") {
                answer += temp[0];
            }
        }
        return answer;
    }
}