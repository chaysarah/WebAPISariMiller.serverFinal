using Microsoft.EntityFrameworkCore;
using MyProject.Context;
using MyProject.Repositories.Interfaces;
using MyProject.Services;

var builder = WebApplication.CreateBuilder(args);

string MyString = "mystring";
builder.Services.AddCors(options =>
{

    options.AddPolicy(name: MyString,
                      policy =>
                      {
                          policy.WithOrigins("*");
                      });
});

// Add services to the container.

builder.Services.AddServices();

var serverVersion = new MySqlServerVersion(new Version(8, 0));

var mySqlConnectionStr = builder.Configuration["DBConnectionString"];
builder.Services.AddDbContextPool<IContext,MyDBContext>(options =>
{
    options.UseMySql(
        mySqlConnectionStr,
        ServerVersion.AutoDetect(mySqlConnectionStr),
        options => options.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: System.TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)
        );
});

//builder.Services.AddDbContext<IContext, MyDBContext>(options =>
   // options.UseMySql(builder.Configuration["DBConnectionString"],serverVersion));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/",()=>"server is running!");

app.Run();
