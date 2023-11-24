using Microsoft.Extensions.Logging;
using MyDeals.Domain.Events;

namespace MyDeals.Application.TodoItems.EventHandlers;
public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("MyDeals Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
