using FluentValidation;
using ProductCommandMicroService.Entities.Concretes;

namespace ProductCommandMicroService.FluentValidators;

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
