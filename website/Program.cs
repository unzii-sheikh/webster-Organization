using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Website.Areas.Identity.Data;
using Website.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WebsiteContextConnection") ?? throw new InvalidOperationException("Connection string 'WebsiteContextConnection' not found.");;

builder.Services.AddDbContext<WebsiteContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<WebsiteUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<WebsiteContext>();
builder.Services.AddRazorPages();

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
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=landingpage}/{id?}")
    .WithStaticAssets();

app.MapRazorPages();
app.Run();
