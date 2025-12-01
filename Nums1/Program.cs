// See https://aka.ms/new-console-template for more information

namespace Nums1;

public class Program
{
    public static void Main(string[] args)
    {
        var nums = new Nums();
        var result = nums.GetOddNumbers([1, 2, 3, 4, 5]);
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
    }
}
