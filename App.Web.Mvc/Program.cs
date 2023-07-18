using App.Data;
using App.Data.Entity;
using App.Web.Mvc.Services;
using App.Web.Mvc.Services.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddSession();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    string? connStr = builder.Configuration.GetConnectionString("DBConStr"); // Builder konfigürasyonu içerisinde "DBConStr" appsettings.json deðerini oku.

    options.UseSqlServer(connStr);
});

builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// JWT - Token ve Cookie araþtýr.

//app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>(); // Uygulama ayaða kalktýðýnda, belirtilen Database'i getir.

    var db = dbContext.Database; 

    if(!await db.CanConnectAsync()) // Eðer ilgili database'yi bulamýyorsan 
    {
        await db.EnsureCreatedAsync();

        // TODO: eðer veritabaný sýfýrdan oluþturulunca
        // içerisindeki bazý tablolarda kayýt olmasý gerekiyorsa
        // burada seed yapýlmalý

        //1. Admin
        //2. Doktor Bülent
        //3. hasta bilmemkim

        User admin = new()
        {
            Email = "admin@noeva.com",
            City = "Çorum",
            Id = 1,
            Password ="123456",
            Phone = "5469389421"
        };

        Category kardiyoloji = new()
        {
            Id=1,
            Description = "Cardio and other things",
            Name = "Cardiology"

        };
    }
}

// Category ve Services(Hospital Services) kýsmýný güncelle.

app.Run();
