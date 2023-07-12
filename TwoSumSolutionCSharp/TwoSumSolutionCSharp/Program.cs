


// Elegant solution with O(n) complexity
static int[] TwoSum(int[] nums, int target)
{
    var DictPairSumValues = new Dictionary<int, int>();

    int i = 0;
    while (i <= nums.Length - 1)
    {
        int value = target - nums[i];

        if (DictPairSumValues.ContainsKey(value))
            return new int[] { DictPairSumValues[value], i };

        DictPairSumValues[nums[i]] = i;
        i++;
    }
    return new int[0];
}

// Solution based in brute force with O(n) complexity
static int[] TwoSumBruteForce(int[] nums, int target)
{
    var i = 0;
    var j = 0;

    while (i <= nums.Length - 1)
    {
        j++;

        if (nums[i] + nums[j] == target)
            return new int[] { i, j };

        if (j == nums.Length - 1)
        {
            j = 0;
            i++;
            j += i;
        }
    }

    return new int[] { 0 };
}
