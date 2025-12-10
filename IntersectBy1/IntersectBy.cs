namespace ClassLibrary1;

public class IntersectBy
{
    public sealed record User
    {
        public required Guid Id { get; init; }
        public required int Age { get; init; }
        public required string Name { get; init; }
    }

    public ICollection<User> FindUsersWithSameName(
        ICollection<User> firstGroup,
        ICollection<User> secondGroup)
    {
        return firstGroup.IntersectBy(secondGroup.Select(x=>x.Name),x=>x.Name).ToList();
    }
}