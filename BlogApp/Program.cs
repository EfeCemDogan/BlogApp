using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogContext>(options => {
    var config = builder.Configuration;
    var GetConnectionString = config.GetConnectionString("sql_connection");
    options.UseSqlite(GetConnectionString);
});
var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();
