// 1356. Sort Integers by The Number of 1 Bits
// Difficulty: Easy
// https://leetcode.com/crt-dot-soluble/
// https://github.com/crt-dot-soluble/leetcode/tree/main/csharp/1356


public class Solution
{
    // Sort in ascending order by the number of set bits.
    // Also known as activated bits, these are the bits set to 1.
    public int[] SortByBits(int[] arr)
    {
        // Sort the array using our Comparer class
        Array.Sort(arr, new Comparer());
        return arr;
    }
}

public class Comparer : IComparer<int>
{
    // Calculates the count of 1s in the binary representations of x and y,
    // compares these counts, and then the integers themselves if the counts are equal
    public int Compare(int x, int y)
    {
        int xCount = CountOnes(x);
        int yCount = CountOnes(y);

        if (xCount != yCount)
        {
            return xCount - yCount; // For ascending order if counts are different
        }
        else
        {
            return x - y; // For ascending order if counts are the same
        }
    }

    // Determines the number of set bits.
    private int CountOnes(int num)
    {
        // The total count of 1's within the representation
        int count = 0;

        // Brian Kernighan's Algorithm for counting set bits
        while (num > 0)
        {
            num &= num - 1; // Unsets the rightmost set bit
            count++;
        }

        return count;
    }
}
