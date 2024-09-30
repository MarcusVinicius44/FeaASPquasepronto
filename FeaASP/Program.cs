using FEAasp.Models;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Adicionar DbContext ao cont�iner de servi�os
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))
    )
);

// Adicionar outros servi�os e configura��es
builder.Services.AddRazorPages();

var app = builder.Build();

// Configura��o do pipeline de solicita��o
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
