using Microsoft.EntityFrameworkCore;
using ProyectoIntroMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbEscritorioContext>(options =>
options.UseSqlServer("Data Source=ANGELMACHADO;Initial Catalog=db_escritorio;Integrated Security=true; TrustServerCertificate=True"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
