using Microsoft.EntityFrameworkCore; // Ensure this using directive is present
using Microsoft.Extensions.DependencyInjection;
using TestNetCore.Data; // Ensure this using directive is present

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PostsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Ensure the Microsoft.EntityFrameworkCore.SqlServer package is installed


builder.Services.AddScoped<IPostRepository, PostRepository>(); // Register PostRepository as a scoped service    
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // Register UnitOfWork

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

