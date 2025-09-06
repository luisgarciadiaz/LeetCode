// See https://aka.ms/new-console-template for more information
public class arrays
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
    public static double FindMedianSortedArrays(int[] nums1, int[] num2)
    {
        List<int> merged= new List<int>(nums1.Length + num2.Length);
        merged.AddRange(nums1);
        merged.AddRange(num2);
        merged.Sort();
        int n = merged.Count;
        if (n % 2 == 1)
        {
            return merged[n / 2];
        }
        else if (n % 2 == 0)
        {
            return (merged[(n / 2) - 1] + merged[n / 2]) / 2.0;
        }
        return 0.0;
    }
} 