using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using vslabfinalproject.Services;
using vslabfinalproject.Data;
using vslabfinalproject.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<ISchoolService, SchoolService>();
builder.Services.AddScoped<DashboardState>();

builder.Services.AddScoped<DashboardAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider =>
    provider.GetRequiredService<DashboardAuthStateProvider>());
builder.Services.AddAuthorizationCore();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
}

app.UseStaticFiles();
app.UseRouting();

using (var scope = app.Services.CreateScope())
{
    var factory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<AppDbContext>>();
    await using var db = await factory.CreateDbContextAsync();
    await db.Database.EnsureCreatedAsync();
    await SeedData.SeedAsync(db);
}

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();