using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;

namespace Persistence.Demo.DomainEvents
{
	public class CreateOrderEvent : IEvent
	{
		public CreateOrderEvent(Guid orderId)
		{
			OrderId = orderId;
		}

		public Guid OrderId { get; }
	}
}
