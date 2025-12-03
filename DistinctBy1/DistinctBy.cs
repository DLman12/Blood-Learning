namespace DistinctBy1;

internal sealed class DistinctBy
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