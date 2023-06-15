using MiddleWareDemo.MiddleWareServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<CustomeMiddleWare>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseClassWithNoImplementationMiddleware();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello Dear Readers from Middleware! Option 2");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
