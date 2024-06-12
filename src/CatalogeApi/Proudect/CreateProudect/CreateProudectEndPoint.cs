
namespace CatalogeApi.Proudect.CreateProudect
{
    public record CreateProudectRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
    public record CreateProudctResponse(Guid id);

    public class CreateProudectEndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {

            app.MapPost("/proudcts",async (CreateProudectRequest request, ISender sender) => {


                var Command = request.Adapt<CreateProductCommand>();
                var result = await sender.Send(Command);
                var response= result.Adapt<CreateProudctResponse>();
                return Results.Created($"/proudects{response.id}", response);
            
            }).WithName("CreateProduct")
        .Produces<CreateProudctResponse>(StatusCodes.Status201Created)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Create Product")
        .WithDescription("Create Product");


            
          
        }
    }
}
