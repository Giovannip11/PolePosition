using PolePosition.Components;
using Microsoft.AspNetCore.Components.Server.Circuits;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços para páginas Razor e Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// --- ATUALIZAÇÃO: Configura o HttpClient com o endereço base da aplicação ---
builder.Services.AddHttpClient("MeuApp", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BaseAddress"] ?? builder.Configuration["urls"] ?? "http://localhost:5000");
});

// Adiciona a injeção do HttpClient
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("MeuApp"));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();