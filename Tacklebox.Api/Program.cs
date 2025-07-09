using LiteDB;
using Tacklebox.Api.Persistence.Database;
using Tacklebox.Api.Persistence.Entities;

var builder = WebApplication.CreateBuilder(args);

// LiteDb
{
    builder.Services.AddSingleton<ILiteDatabase>(_ => new LiteDatabase("tacklebox.db"));
    builder.Services.AddScoped<IWebhookRepository, WebhookRepository>();
}
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/webhook/insert", (IWebhookRepository repository, WebhookEntity webhookEntity) => 
{
    var result = repository.Insert(webhookEntity);
    return Results.Ok(new { Id = result.AsInt32, Message = "Webhook inserted successfully" });
});

app.MapGet("/webhook/{id:int}", (IWebhookRepository repository, int id) => 
{
    var webhook = repository.Find(id);
    return webhook != null ? Results.Ok(webhook) : Results.NotFound();
});

app.MapGet("/webhook/all", (IWebhookRepository repository) => 
{
    var webhooks = repository.FindAll();
    return Results.Ok(webhooks);
});

app.Run();