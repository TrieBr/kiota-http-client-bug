using KiotaBlazorBug.Client;
using KiotaBlazorBug.Client.Pages;
using KiotaBlazorBug.Components;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<PetStoreClient>(e =>
{
    var authProvider = new AnonymousAuthenticationProvider();
    // Create request adapter using the HttpClient-based implementation
    var adapter = new HttpClientRequestAdapter(authProvider);
    // Create the API client
    return new PetStoreClient(adapter);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(KiotaBlazorBug.Client._Imports).Assembly);

app.Run();
