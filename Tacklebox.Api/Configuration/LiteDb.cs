using LiteDB;
using Tacklebox.Api.Persistence.Database;

namespace Tacklebox.Api.Configuration;

public static class LiteDb
{
    public static WebApplicationBuilder UseLiteDb(this WebApplicationBuilder builder)
    {

        var connectionString = builder.Configuration.GetConnectionString("Database") 
                               ?? builder.Configuration.GetValue<string>("Database:ConnectionString") 
                               ?? throw new InvalidOperationException("Database connection string not configured in configuration or environment variables.");
        
        builder.Services.AddSingleton<ILiteDatabase>(_ => new LiteDatabase(connectionString));
        builder.Services.AddScoped<IWebhookRepository, WebhookRepository>();
        return builder;
    }
}