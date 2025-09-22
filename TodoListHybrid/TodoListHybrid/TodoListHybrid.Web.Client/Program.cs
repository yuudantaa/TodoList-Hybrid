using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoListHybrid.Shared.Services;
using TodoListHybrid.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the TodoListHybrid.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
