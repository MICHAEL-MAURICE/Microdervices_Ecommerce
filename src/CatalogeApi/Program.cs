var builder = WebApplication.CreateBuilder(args);

var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
    
});

builder.Services.AddValidatorsFromAssembly(assembly);

builder.Services.AddMarten(opt => {


    opt.Connection(builder.Configuration.GetConnectionString("Database")!);

}).UseLightweightSessions();

builder.Services.AddCarter();

var app = builder.Build();

app.MapCarter();

app.Run();
