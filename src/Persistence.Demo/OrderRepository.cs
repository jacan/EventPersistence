using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persisted.Events;
using Persistence.Demo.DomainEvents;

namespace Persistence.Demo
{
	public class OrderRepository : IEventRepository<Order>
	{
		private readonly OrderEventDispatcher _eventDispatcher;

		public OrderRepository()
		{
			_eventDispatcher = new OrderEventDispatcher();
		}

		public Order GetById(int id)
		{
			throw new NotImplementedException();
			// Make your own persistence layer
		}

		public IEnumerable<Order> GetAll()
		{
			throw new NotImplementedException();
			// Do Mongo or MSSQL or whatever you need to
		}

		public void Store(Order itemToStore)
		{
			// Let's stream the changes down the stream to apply changes
			// If needed, one could stream / serialize events for rollbacks
			var eventsThatNeedPersistence = itemToStore.GetNonPersistedEvents();
			_eventDispatcher.DispatchAll(eventsThatNeedPersistence);	
		}
	}
}
