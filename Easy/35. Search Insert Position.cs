// https://leetcode.com/problems/search-insert-position
// 03/04/25
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] >= target) {
                return i;
            } else if (i == nums.Length - 1) {
                return i + 1;
            }
        }
        return -1;
    }
}