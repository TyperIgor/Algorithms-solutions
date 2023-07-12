

// Solution using HashSet to find duplicates numbers with complexity O(n) --

// Should Find numbers that repeat itself and return the number that fit position

// Example 1:
// input --> { 1, 2, 3, 2 };

// output [2,4]

//Example 2:  
//input {1,2,3,4,3} | output [3,5]

static int[] FindErrorNums(int[] nums)
{
    HashSet<int> numsReplited = new();

    for (int i = 0; i <= nums.Length - 1; i++)
    {
        if (!numsReplited.Add(nums[i]))
            return new int[] { nums[i], i += 1 };

        numsReplited.Add(nums[i]);
    }

    return new int[0];
}
