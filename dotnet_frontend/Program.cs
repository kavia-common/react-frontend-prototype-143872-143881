using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// For automated preview systems, prefer ASPNETCORE_URLS for binding (e.g. http://0.0.0.0:5000).
// Also ensure Kestrel supports HTTP/1.1 by default.
builder.WebHost.ConfigureKestrel(options =>
{
    // Keep defaults; no hard-coded ports here. Binding is controlled via ASPNETCORE_URLS.
    options.AddServerHeader = false;
    options.ConfigureEndpointDefaults(lo => lo.Protocols = HttpProtocols.Http1AndHttp2);
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// In many preview environments HTTPS is not terminated in the container;
// still keep redirect if available, it's harmless.
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// MVC default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Map health endpoint explicitly as fallback, though we have a controller for it.
// This helps if routing constraints change.
app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "dotnet_frontend" }));

// Run the app. Binding to 0.0.0.0:5000 is handled by ASPNETCORE_URLS environment variable
// or the --urls argument in our start scripts.
app.Run();
