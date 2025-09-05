// See https://aka.ms/new-console-template for more information
internal class arrays
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.TryGetValue(complement, out int index))
            {
                return new int[] { index, i };
            }
            seen[nums[i]] = i;
        }
        throw new InvalidOperationException("No valid two sum found.");
    }
}