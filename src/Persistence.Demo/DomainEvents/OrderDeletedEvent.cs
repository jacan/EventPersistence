using System;
using Persisted.Events;

namespace Persistence.Demo.DomainEvents
{
    public class OrderDeletedEvent : IEvent
    {
        public Guid OrderId { get; }
        public DateTime Timestamp { get; }

        public OrderDeletedEvent(Guid orderId, DateTime timestamp)
        {
            OrderId = orderId;
            Timestamp = timestamp;
        }
    }
}