using FizzBuzzApplication.Web.Interface;
using FizzBuzzApplication.Web.Models;
using FizzBuzzApplication.Web.Services;
using FizzBuzzApplication.Web.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IFizzBuzzService,FizzBuzzService>();
builder.Services.AddScoped<IFizzBuzzGenerator,FizzBuzzGenerator>();
builder.Services.AddScoped<IFizzBuzzGenerator,BuzzGenerator>();
builder.Services.AddScoped<IFizzBuzzGenerator,FizzGenerator>();
builder.Services.AddSingleton<IDateTimeService,DateTimeService>();


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
