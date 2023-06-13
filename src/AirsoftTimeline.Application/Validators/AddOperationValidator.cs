using AirsoftTimeline.Application.Entidades;
using AirsoftTimeline.Application.ValueObjects;
using FluentValidation;

namespace AirsoftTimeline.Application.Validators
{
    public class AddOperationValidator : AbstractValidator<OperationEntity>
    {
        public AddOperationValidator()
        {
            RuleFor(x => x.Operation.Name).NotEmpty().WithMessage("Informe um nome válido!");
            RuleFor(x => x.Operation.Name).Length(3, 20);

            RuleFor(x => x.Operation.Place).NotEmpty().WithMessage("Informe um local válido!");
            RuleFor(x => x.Operation.Name).Length(3, 30);

            RuleFor(x => x.Operation.Teams).Must(BeValidTeams).WithMessage("Informe pelo menos 2 times!");
        }

        private bool BeValidTeams(List<TeamVO> teams)
        {
            return teams.Count > 1;
        }
    }
}
