using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;
using Persistence.Demo.DomainEvents;

namespace Persistence.Demo
{
	public class Order : IEventAggregate
	{
		private readonly List<OrderLine> _orderLines;
		private readonly EventStore _eventStore;

		public Guid OrderId { get; }

		public static Order CreateOrder()
		{
			var newOrder = new Order(Guid.NewGuid());
			newOrder._eventStore.AddEvent(new CreateOrderEvent(newOrder.OrderId));

			return newOrder;
		}

		internal Order(Guid orderId)
		{
			OrderId = orderId;
			_orderLines = new List<OrderLine>();
			_eventStore = new EventStore();
		}

		public void AddToOrder(OrderLine orderLine)
		{
			_orderLines.Add(orderLine);
			_eventStore.AddEvent(new OrderLineAddedEvent(orderLine));
		}

		public void UpdateOrderLineQuantity(int itemId, int newQuantity)
		{
			var orderline = _orderLines.SingleOrDefault(x => x.ItemId == itemId);

			if (orderline == null)
			{
				return;
			}

			orderline.UpdateQuantity(newQuantity);
			_eventStore.AddEvent(new OrderLineQuantityUpdatedEvent(itemId, newQuantity));
		}

		public void DeleteOrder()
		{
			_eventStore.AddEvent(new DeleteOrderEvent(OrderId));
		}
		
		public IReadOnlyCollection<IEvent> GetNonPersistedEvents() => _eventStore.DequeueEvents();
	}
}
