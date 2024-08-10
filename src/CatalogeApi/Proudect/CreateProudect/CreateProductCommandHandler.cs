

namespace CatalogeApi.Proudect.CreateProudect;

    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price):ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);


public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Category).NotEmpty().WithMessage("Category is required");
        RuleFor(x => x.ImageFile).NotEmpty().WithMessage("ImageFile is required");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
    }
}

public class CreateProductCommandHandler(IDocumentSession session) : ICommandHandler<CreateProductCommand, CreateProductResult>

{
    public async Task<CreateProductResult> Handle(CreateProductCommand Command, CancellationToken cancellationToken)
    {
    
        var proudect = new Product
        {
           Name = Command.Name,
           Discription=Command.Description,
           Category=Command.Category,
           ImageFile=Command.ImageFile, 
           Price=Command.Price,
           
        };
      
        session.Store(proudect);
        await session.SaveChangesAsync(cancellationToken);

        return new CreateProductResult(proudect.Id);

       
    }
}

