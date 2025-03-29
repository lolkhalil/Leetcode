// https://leetcode.com/problems/remove-duplicates-from-sorted-array
// 29/03/25
// It needs the nums without the Duplicates and the Index
public int RemoveDuplicates(int[] nums) {
    int index = 0;
    for (int i = 0; i < nums.Length; i++) {
        // Don't get the last number
        if (i != nums.Length - 1) {
            // Checking if there's a unique value
            if (nums[i] != nums[i+1]) {
                nums[index] = nums[i];
                index++;
            }
        } else {
            // Adding the last number
            nums[index] = nums[i];
            index++
        }
    }
    return index;
}