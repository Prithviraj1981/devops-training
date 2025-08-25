    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer(); // Required for Swagger
    builder.Services.AddSwaggerGen(); // Adds Swagger generation services

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger(); // Enables Swagger middleware
        app.UseSwaggerUI(); // Enables Swagger UI middleware
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    // // Add a simple "Hello World" endpoint
    // app.MapGet("/hello", () => "Hello World!");

    app.Run();