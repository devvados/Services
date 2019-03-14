using FactorialService.Models;
using FluentValidation;

namespace FactorialService.Validators
{
    public class FactorialRequestValidator : AbstractValidator<FactorialRequest>
    {
        public FactorialRequestValidator()
        {
            RuleFor(request => request.Number).InclusiveBetween(1,12);
        }
    }
}