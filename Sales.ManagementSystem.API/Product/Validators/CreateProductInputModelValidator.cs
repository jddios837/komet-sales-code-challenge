using FluentValidation;
using Sales.ManagementSystem.Shared.Product.InputModels;

namespace Sales.ManagementSystem.API.Product.Validators;

public class CreateProductInputModelValidator : AbstractValidator<CreateProductInputModel>
{
    public CreateProductInputModelValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Description).NotEmpty().MaximumLength(5000);
        RuleFor(x => x.Code).NotEmpty().GreaterThanOrEqualTo(1);
        RuleFor(x => x.CategoryId).NotEmpty();
    }
}