using EmployeeDataAgent.Repositories;
using EmployeeDataAgent.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<JsonFileRepository>();
builder.Services.AddScoped<PromptService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

// Enable in Dev (or everywhere if you want)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Host Swagger UI at root "/"
        c.RoutePrefix = "swagger";
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
    }); // UI at /swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
