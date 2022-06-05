using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

var supportedLanguages = new[] { new CultureInfo("en"), new CultureInfo("es") };

// Add services to the container.
builder.Services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix, opt => opt.ResourcesPath = "Resources");
builder.Services.Configure<RazorViewEngineOptions>(o => { o.ViewLocationFormats.Add("/Views/Blog/Posts/{0}" + RazorViewEngine.ViewExtension); });

var app = builder.Build();

app.UseStaticFiles();

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(supportedLanguages[0]),
    SupportedCultures = supportedLanguages,
    SupportedUICultures = supportedLanguages
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
