using Azure.Identity;
using BookStoreLite.Configuration;
using BookStoreLite.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Microsoft.FeatureManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureAppConfiguration(options =>
{
    options.Connect(new Uri(Environment.GetEnvironmentVariable("BOOKSTORELITE_APP_CONFIG")!), new DefaultAzureCredential())
                .Select("Bookstore:*", LabelFilter.Null)
                .ConfigureRefresh(refreshOptions => refreshOptions.Register("Bookstore:Sentinel", refreshAll: true))
                .ConfigureKeyVault(kv => kv.SetCredential(new DefaultAzureCredential()));
    options.UseFeatureFlags();
});

builder.Services.AddAzureAppConfiguration();
builder.Services.Configure<BookstoreSettings>(
    builder.Configuration.GetSection("Bookstore"));
builder.Services.AddFeatureManagement();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureBookStoreLiteDB")));
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseAzureAppConfiguration();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
