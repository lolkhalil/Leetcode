// https://leetcode.com/problems/sort-colors
// 29/03/25
// TODO: Could you come up with a one-pass algorithm using only constant extra space?
public class Solution {
    public void SortColors(int[] nums) {
        var values = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 0 },
            { "two", 0 }
        };

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                values["zero"] += 1;
            } else if (nums[i] == 1) {
                values["one"] += 1;
            } else if (nums[i] == 2) {
                values["two"] += 1;
            }
        }
        int index = 0;
        for (int i = 0; i < values["zero"]; i++) {
            nums[index] = 0;
            index++;
        }
        for (int i = 0; i < values["one"]; i++) {
            nums[index] = 1;
            index++;
        }
        for (int i = 0; i < values["two"]; i++) {
            nums[index] = 2;
            index++;
        }
    }
}