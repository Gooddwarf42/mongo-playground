namespace MongoPlayground.Data.Entities;

public sealed record User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
}
