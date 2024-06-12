using FluentValidation;
using ProductQueryMicroService.Entities.Concretes;

namespace ProductQueryMicroService.FluentValidators;

public class ProductValidator : AbstractValidator<Product> {

    public ProductValidator()  { 

        RuleFor(x=> x.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100);

        RuleFor(x => x.Description)
            .NotEmpty()
            .MinimumLength(5);
    }
}
