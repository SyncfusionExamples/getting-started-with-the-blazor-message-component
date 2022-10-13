using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorApp;
using Syncfusion.Blazor;
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA0NzI4QDMyMzAyZTMxMmUzMElnd0owNjFveXpldXBBVW9aQ3BkR2VGQUZRK2doVFZPak92T2VzNm5MR1k9");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
