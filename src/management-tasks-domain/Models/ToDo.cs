using Management.Tasks.Domain.Models.Base;

namespace Management.Tasks.Domain.Models;

public class ToDo : Entity
{
    private string Name { get; set; }

    private string Description { get; set; }

    private DateTime CreatedOn { get; set; }

    private bool IsDeleted { get; set; }

    private DateTime DeletedOn { get; set; }

    private ToDo() : base() {}

    private ToDo(string name, string description)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Description = description ?? throw new ArgumentNullException(nameof(name));
        CreatedOn = DateTime.UtcNow;
        IsDeleted = false;
    }

    public ToDo Create(string name, string description) =>
        new(name, description);
}