namespace DistinctBy1;

public class DistinctBy
{
    public sealed record User
    {
        public required Guid Id { get; init; }
        public required int Age { get; init; }
        public string? Name { get; init; }
    }

    public ICollection<User> DistinctByIdUsers(ICollection<User> users)
    {
        return users.DistinctBy(x => x.Id).ToList();
    }
}