





class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        seen = set(nums)
        return seen.__len__() < nums.__len__()