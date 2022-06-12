using FluentValidation;

namespace Management.Tasks.Domain.Models.Assignments;
public class AssignmentValidator : AbstractValidator<Assignment>
{
    public AssignmentValidator()
    {
        RuleFor(a => a.Name)
            .MaximumLength(20).WithMessage("No máximo 100 caracteres.")
            .NotEmpty().WithMessage("O nome da tarefa deve ser inserido.")
            .NotNull().WithMessage("O nome da tarefa não pode ser nulo.");
        
        RuleFor(a => a.Description)
            .MaximumLength(100).WithMessage("No máximo 100 caracteres.");
    }
}