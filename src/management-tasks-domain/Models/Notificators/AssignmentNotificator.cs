namespace Management.Tasks.Domain.Models.Notificators;
public class AssignmentNotificator
{
    public bool Alert { get; private set; }
    
    public DateTime LimitDate { get; private set; }
}