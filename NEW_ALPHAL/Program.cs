using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NEW_ALPHAL.Models.Identitys;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";  // S?a l?i trùng LogoutPath
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

builder.Services.AddRazorPages();

// Add repository services


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
// Đảm bảo có trong Startup.cs hoặc Program.cs
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Thêm middleware xác th?c
app.UseAuthentication();  // Thêm dòng này ?? b?t tính n?ng xác th?c
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // C?u hình routing cho các area
    endpoints.MapControllerRoute(
        name: "Admin",
        pattern: "{area:exists}/{controller=Products}/{action=Index}/{id?}");

    // C?u hình routing m?c ??nh
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.MapRazorPages();
app.Run();
