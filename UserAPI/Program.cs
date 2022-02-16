using UserAPI.Model;
using UserAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<UsersDatabaseSettings>(builder.Configuration.GetSection("UsersDatabase"));
builder.Services.AddSingleton<UserService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllHeaders",
          builder =>
          {
              builder.AllowAnyOrigin()
                     .AllowAnyHeader()
                     .AllowAnyMethod();
          });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Access-Control-Allow-Methods", "GET,PUT,POST,DELETE,HEAD,OPTIONS");
    context.Response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type,append,delete,entries,foreach,get,has,keys,set,values,Authorization");
    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

    await next();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
