using NSwag;
using SimpleTranslator.Middleware;
using SimpleTranslator.Models;

var builder = WebApplication.CreateBuilder(args);

System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS","./rival-translator-e11f22b79f4b.json");
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddOpenApiDocument(options =>
{
    options.PostProcess = document =>
    {
        document.Info = new OpenApiInfo
        {
            Version = "v1",
            Title = GetConfigValue("SwaggerTitle", "Simple Translator"),
            Description = GetConfigValue("SwaggerDescription"),
            Contact = new OpenApiContact
            {
                Name = GetConfigValue("SwaggerContactUsText"),
                Url = GetConfigValue("SwaggerContactUsUrl"),
            }
        };
    };
});

string GetConfigValue(string key, string defaultValue = "")
{
    return builder.Configuration.GetSection(key).Get<string>() ?? defaultValue;
}

builder.Services.AddControllers(options =>
{
    // options.Filters.Add<HttpResponseExceptionFilter>();
});

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseOpenApi();
    app.UseSwaggerUi();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(name: "translation",
                pattern: "translation/{*translate}",
                defaults: new { controller = "Translation", action = "Translate" });


app.Run();