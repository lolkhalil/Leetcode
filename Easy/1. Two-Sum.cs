// https://leetcode.com/problems/two-sum/
// 28/03/2025
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (i == j) { // Don't add the same number from the same index
                    continue;
                }

                int sum = nums[i] + nums[j];
                if (sum == target) {
                    // You can return the answer in any order.
                    answer[0] = j;
                    answer[1] = i;
                    return answer;
                }
            }
        }

        return answer;
    }
}

// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:
// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:
// Input: nums = [3,3], target = 6
// Output: [0,1]
