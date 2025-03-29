// https://leetcode.com/problems/two-sum/
// 28/03/2025
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                int sum = nums[i] + nums[j];
                if (i == j) {
                    continue;
                }
                if (sum == target) {
                    answer[0] = j;
                    answer[1] = i;
                    return answer;
                }
            }
        }

        return answer;
    }
}