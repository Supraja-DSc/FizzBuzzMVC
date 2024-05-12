using FizzBuzz.Interface;
using FizzBuzz.Models;
using FizzBuzz.Services;
using FizzBuzz.Services.Interface;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IFizzBuzzGenerator,FizzBuzzGenerator>();
builder.Services.AddScoped<IFizzBuzzGenerator,FizzGenerator>();
builder.Services.AddScoped<IFizzBuzzGenerator,BuzzGenerator>();
builder.Services.AddScoped<IFizzBuzzService,FizzBuzzService>();  

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
    pattern: "{controller=FizzBuzz}/{action=Index}/{Id?}");

app.Run();