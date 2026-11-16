using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 1. Session support
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// 2. HttpClient
builder.Services.AddHttpClient();

// 3. Define the ApiService HERE so there are no missing file errors
builder.Services.AddScoped<ApiService>(provider =>
{
    var client = provider.GetRequiredService<HttpClient>();
    var config = provider.GetRequiredService<IConfiguration>();
    var contextAccessor = provider.GetRequiredService<IHttpContextAccessor>();

    // Set the URL to your API (change 7123 if your API uses a different port)
    client.BaseAddress = new Uri(config["ApiSettings:BaseUrl"] ?? "https://localhost:7123");

    var token = contextAccessor.HttpContext?.Session.GetString("JwtToken");
    if (!string.IsNullOrEmpty(token))
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    return new ApiService { Client = client };
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();

// --- THIS IS THE APISERVICE CLASS ---
public class ApiService
{
    public HttpClient Client { get; set; } = new HttpClient();
}