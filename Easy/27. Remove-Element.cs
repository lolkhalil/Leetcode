// https://leetcode.com/problems/remove-element
// 29/03/25
public int RemoveElement(int[] nums, int val) {
    int index = 0;
    for (int i = 0; i < nums.Length; i++) {
        if (nums[i] != val) {
            nums[index] = nums[i];
            index++;
        }
    }
    return index;
}