using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;

namespace Persistence.Demo.DomainEvents
{
	public class OrderLineAddedEvent : IEvent
	{
		public OrderLine OrderLineAdded { get; }
		public OrderLineAddedEvent(OrderLine orderline)
		{
			OrderLineAdded = orderline;
		}
	}
}
