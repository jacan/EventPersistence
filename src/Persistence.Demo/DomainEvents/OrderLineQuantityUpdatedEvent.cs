using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;

namespace Persistence.Demo.DomainEvents
{
	public class OrderLineQuantityUpdatedEvent : IEvent
	{
		public int NewQuantity { get; }
		public int ItemId { get; }

		public OrderLineQuantityUpdatedEvent(int itemId, int newQuantity)
		{
			ItemId = itemId;
			NewQuantity = newQuantity;
		}
	}
}
