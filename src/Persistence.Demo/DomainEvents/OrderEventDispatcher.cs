using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;

namespace Persistence.Demo.DomainEvents
{
	public class OrderEventDispatcher : EventDispatcher
	{
		protected override void Dispatch(IEvent @event)
		{
			Handle((dynamic)@event);
		}

		private void Handle(OrderLineAddedEvent @event)
		{
			Console.WriteLine("Adding orderline, to order");
		}

		private void Handle(OrderLineQuantityUpdatedEvent @event)
		{
			Console.WriteLine($"Updating orderline {@event.ItemId} with quantity {@event.NewQuantity}");
		}

		private void Handle(CreateOrderEvent @event)
		{
			Console.WriteLine($"Creating order {@event.OrderId}");
		}
	}
}
