using Demo.Queries.DocumentType;
using Demo.Queries.Person;
using Demo.Queries.Producto;
using Demo.Repository.Person;
using Demo.Repository.Producto;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});


builder.Services.AddTransient<IDocumenTypeQueries, DocumenTypeQueries>();
builder.Services.AddTransient<IPersonQueries, PersonQueries>();
builder.Services.AddTransient<IPersonRepository, PersonRepository>();


//Tabla Producto
builder.Services.AddTransient<IProductoQueries, ProductoQueries>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
