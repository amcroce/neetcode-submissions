public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = [.. nums];
        return seen.Count < nums.Length;
    }
}