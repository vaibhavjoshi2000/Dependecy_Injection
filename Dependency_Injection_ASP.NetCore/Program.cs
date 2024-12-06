using Dependency_Injection_ASP.NetCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Bulder Service I have registered
builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();
//Here AddScoped is simply active instance available. In this specific term when you make an HTTP request this EmailSenderService
//will get used. And if you created new HTTP request another new instance of AddScoped get created. And for Singelton it will share
//b/w requests.
//In Short AddScoped means how long instance will get created and how long it will alive.

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
