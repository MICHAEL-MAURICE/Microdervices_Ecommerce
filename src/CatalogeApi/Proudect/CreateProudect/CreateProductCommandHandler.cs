using CatalogeApi.Models;
using MediatR;

namespace CatalogeApi.Proudect.CreateProudect;

    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price):IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);

//public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
//{
//    public CreateProductCommandValidator()
//    {
//        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
//        RuleFor(x => x.Category).NotEmpty().WithMessage("Category is required");
//        RuleFor(x => x.ImageFile).NotEmpty().WithMessage("ImageFile is required");
//        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
//    }
//}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>

{
    public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

