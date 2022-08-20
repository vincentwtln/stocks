using BlazorApp1;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjkyMjUwQDMyMzAyZTMyMmUzMFlwcVpSMFE3K2VjVU9hQkIrYXY2QUZ2Nm9lajIyZ0tXTnZGbGgwMUFZNDA9");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<ApiKey>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://financialmodelingprep.com/api/v3/") });
/* builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); */

await builder.Build().RunAsync();
