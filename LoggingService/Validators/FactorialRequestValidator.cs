using LoggingService.Models;
using FluentValidation;

namespace LoggingService.Validators
{
    public class FactorialRequestValidator : AbstractValidator<LogRequest>
    {
        public FactorialRequestValidator()
        {
            RuleFor(request => request.Message).NotEmpty();
        }
    }
}