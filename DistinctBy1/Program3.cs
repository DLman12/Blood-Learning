namespace DistinctBy1;

public class Program3
{
    public static void Main(string[] args)
    {
        
        var repeatedGuid = Guid.NewGuid();
        
        var users = new List<DistinctBy.User>
        {
            new() { Id = repeatedGuid, Age = 18, Name = "John Doe" },
            new() { Id = Guid.NewGuid(), Age = 18, Name = "Jane Doe" },
            new() { Id = repeatedGuid, Age = 18, Name = "John Doe" }
        };
        
        var result = new DistinctBy().DistinctByIdUsers(users);
        foreach (var i in result)
        {   
            Console.WriteLine($"{i.Id} - {i.Age} - {i.Name}");
        }
    }
}