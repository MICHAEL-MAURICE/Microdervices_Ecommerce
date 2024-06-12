using BuildingBlocks.CQRS;
using CatalogeApi.Models;
using MediatR;

namespace CatalogeApi.Proudect.CreateProudect;

    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price):ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);


public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>

{
    public async Task<CreateProductResult> Handle(CreateProductCommand Command, CancellationToken cancellationToken)
    {
        var proudect = new Proudct
        {
           Name = Command.Name,
           Discription=Command.Description,
           Gategory=Command.Category,
           ImageFile=Command.ImageFile, 
           Price=Command.Price,
           
        };


        return new CreateProductResult(Guid.NewGuid());

       
    }
}

