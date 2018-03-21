using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persisted.Events
{
	public class EventStore
	{
		private readonly List<IEvent> _eventsNotPersisted;

		public EventStore()
		{
			_eventsNotPersisted = new List<IEvent>();
		}

		public IReadOnlyCollection<IEvent> DequeueEvents()
		{
			var readonlyEvents = _eventsNotPersisted.ToList();
			_eventsNotPersisted.Clear();

			return readonlyEvents;
		}

		public void AddEvent(IEvent @event)
		{
			_eventsNotPersisted.Add(@event);
		}
	}
}
