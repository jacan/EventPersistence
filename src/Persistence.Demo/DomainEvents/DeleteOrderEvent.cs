using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;

namespace Persistence.Demo.DomainEvents
{
	public class DeleteOrderEvent : IEvent
	{
		public DeleteOrderEvent(Guid orderId)
		{
			OrderId = orderId;
		}

		public Guid OrderId { get; }
	}
}
