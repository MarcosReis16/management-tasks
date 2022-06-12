using FluentValidation;

namespace Management.Tasks.Domain.Models.Notificators;
public class AssignmentNotificatorValidator : AbstractValidator<AssignmentNotificator>
{
    public AssignmentNotificatorValidator()
    {
        RuleFor(n => n.LimitDate)
            .NotNull().DependentRules(() => {
                RuleFor(n => n.Alert).Equal(true);
            });
    }
}