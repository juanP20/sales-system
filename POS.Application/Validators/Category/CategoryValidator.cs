using FluentValidation;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;

namespace POS.Application.Validators.Category
{
    public class CategoryValidator : AbstractValidator<CategoryRequestDto>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
             .NotNull().WithMessage("the field Name cannot be null")
             .NotEmpty().WithMessage("The field Name cannot empty");
        }
    }
}
