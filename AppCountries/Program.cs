using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AppCountries;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.Extensions.DependencyInjection;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSweetAlert2();
builder.Services.AddBlazoredToast();
builder.Services.AddHttpClient<CountriesService>(client =>
{
    client.BaseAddress = new Uri("https://restcountries.com/v3.1/");
});
builder.Services.AddScoped<FirebaseService>();

await builder.Build().RunAsync();

