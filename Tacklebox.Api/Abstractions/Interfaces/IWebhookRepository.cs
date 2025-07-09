using LiteDB;
using Tacklebox.Api.Persistence.Entities;

namespace Tacklebox.Api.Persistence.Database;

public interface IWebhookRepository
{
    BsonValue Insert(WebhookEntity entity);
    bool Update(WebhookEntity entity);
    bool Delete(int id);
    WebhookEntity Find(int id);
    IEnumerable<WebhookEntity> FindAll();
}