var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddHttpClient("ShoppingAPIClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:8518/");
    //client.BaseAddress = new Uri(app.Configuration.GetConnectionString("ShoppingAPIUrl"));
});
builder.Services.AddControllersWithViews();

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
