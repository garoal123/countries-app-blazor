using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AppCountries;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.Extensions.DependencyInjection;
using Blazored.Toast;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using BlazorLogin.Client.Extensiones;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Agregar HttpClient con la base address del host
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Agregar servicio de SweetAlert2
builder.Services.AddSweetAlert2();

// Agregar servicio de Blazored Toast
builder.Services.AddBlazoredToast();

// Configuración del HttpClient para CountriesService
builder.Services.AddHttpClient<CountriesService>(client =>
{
    client.BaseAddress = new Uri("https://restcountries.com/v3.1/");
});

// Agregar FirebaseService
builder.Services.AddScoped<FirebaseService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, AutenticacionExtension>();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
