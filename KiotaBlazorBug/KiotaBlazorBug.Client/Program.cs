using KiotaBlazorBug.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<PetStoreClient>(e =>
{
    var authProvider = new AnonymousAuthenticationProvider();

    // Create request adapter using the HttpClient-based implementation
    HttpClient? httpClient = null;
    // Uncomment this to crash.
    // httpClient = KiotaClientFactory.Create();
    httpClient = new HttpClient();
    var adapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
    // Create the API client
    return new PetStoreClient(adapter);
});


await builder.Build().RunAsync();
