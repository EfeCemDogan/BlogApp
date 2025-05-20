using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(options => {
    var config = builder.Configuration;
    var GetConnectionString = config.GetConnectionString("sql_connection");
    options.UseSqlite(GetConnectionString);
});
var app = builder.Build();

SeedData.TestVerileriniDoldur(app);

app.MapDefaultControllerRoute();

app.Run();
