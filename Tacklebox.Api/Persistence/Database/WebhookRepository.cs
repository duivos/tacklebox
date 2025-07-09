using LiteDB;
using Tacklebox.Api.Persistence.Entities;

namespace Tacklebox.Api.Persistence.Database;

public class WebhookRepository(ILiteDatabase database) : BaseRepository<WebhookEntity>(database), IWebhookRepository;