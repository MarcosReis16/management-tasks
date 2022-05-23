namespace Management.Tasks.Domain.Models.Base;
public class Entity
{
    protected Entity() => 
        Id = Guid.NewGuid();

    protected Guid Id { get; set; }
}