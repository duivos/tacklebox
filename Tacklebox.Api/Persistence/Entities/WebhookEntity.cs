namespace Tacklebox.Api.Persistence.Entities;

public class WebhookEntity(int id, string endpoint, string payload)
{
    public int Id { get; set; } = id;
    public string Endpoint { get; set; } = endpoint;
    public string Payload { get; set; } = payload;
    public DateTime ReceivedAt { get; } = DateTime.UtcNow;
}