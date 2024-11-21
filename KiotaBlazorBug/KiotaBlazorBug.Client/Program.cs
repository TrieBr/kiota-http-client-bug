using KiotaBlazorBug.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<PetStoreClient>(e =>
{
    var authProvider = new AnonymousAuthenticationProvider();
    // Create request adapter using the HttpClient-based implementation
    var adapter = new HttpClientRequestAdapter(authProvider);
    // Create the API client
    return new PetStoreClient(adapter);
});


await builder.Build().RunAsync();
