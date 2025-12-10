namespace ClassLibrary1;

public class Program4
{
    public static void Main(string[] args)
    {
        
 
        var users1 = new List<IntersectBy.User>
        {
            new() { Id = Guid.NewGuid(), Age = 18, Name = "John Doe" },
            new() { Id = Guid.NewGuid(), Age = 21, Name = "Jane Doe" },
            new() { Id = Guid.NewGuid(), Age = 18, Name = "John Double" }
        };
        
        var users2 = new List<IntersectBy.User>
        {
            new() { Id = Guid.NewGuid(), Age = 19, Name = "John Doe" },
            new() { Id = Guid.NewGuid(), Age = 18, Name = "Jane Den" },
            new() { Id = Guid.NewGuid(), Age = 17, Name = "John Two" }
        };
        
        var result = new IntersectBy().FindUsersWithSameName(users1, users2);
        foreach (var user  in result)
        {   
            Console.WriteLine($"{user.Id} - {user.Age} - {user.Name}");
        }
    }
}