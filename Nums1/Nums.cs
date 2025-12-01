namespace Nums1;

public class Nums
{
    public IEnumerable<int> GetOddNumbers(ICollection<int>? numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return [];
        }
        return numbers.Where(x => x % 2 != 0);
    } 
}