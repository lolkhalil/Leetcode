// https://leetcode.com/problems/length-of-last-word
// 03/04/25
public class Solution {
    public int LengthOfLastWord(string s) {
        string[] list = s.Split(" ");
        for (int i = list.Length - 1; i > -1; i--) {
            if (list[i].Length != 0) {
                return list[i].Length;
            }
        }
        
        return list[list.Length - 1].Length;
    }
}