using Management.Tasks.Domain.Models.Base;

namespace Management.Tasks.Domain.Models.Assignments;

public class Assignment : Entity
{
    public string Name { get; private set; }

    public string Description { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public bool IsDeleted { get; private set; }

    public DateTime DeletedOn { get; private set; }

    private Assignment() : base() {}

    private Assignment(string name, string description)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Description = description ?? throw new ArgumentNullException(nameof(name));
        CreatedOn = DateTime.UtcNow;
        IsDeleted = false;
    }

    public Assignment Create(string name, string description) =>
        new(name, description);
}