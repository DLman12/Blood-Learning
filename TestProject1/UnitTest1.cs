using Nums1;
using Xunit;
using Assert = Xunit.Assert;

namespace TestProject1;

public class Tests
{

    private readonly Nums _nums = new();

    [Fact]
    public void Test_GetOddNumbers_ShouldReturnOddNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var expected = new List<int> { 1, 3, 5, 7, 9 };

        var result = _nums.GetOddNumbers(numbers);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_GetOddNumbers_ShouldReturnOddNumbers2()
    {
        var numbers = new List<int> { 1, -2, 3, 4, -5, 6, 7, 8, -9 };
        var expected = new List<int> { 1, 3, -5, 7, -9 };

        var result = _nums.GetOddNumbers(numbers);

        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_GetOddNumbers_ShouldReturnOddNumbers_EmptyNumbers()
    {
        var numbers = new List<int> {};
        var expected = new List<int> {};

        var result = _nums.GetOddNumbers(numbers);

        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_GetOddNumbers_ShouldReturnOddNumbers_NullNumbers()
    {
        ICollection<int>? numbers = null;
        var expected = new List<int> {};

        var result = _nums.GetOddNumbers(numbers);

        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Test_GetOddNumbers_ShouldReturnOddNumbers_NoNumbers()
    {
        var numbers = new List<int> { 2, 4, 6, 8, 10 };
        var expected = new List<int> {};

        var result = _nums.GetOddNumbers(numbers);

        Assert.Equal(expected, result);
    }
}