using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persisted.Events
{
	public interface IEventAggregate : IEvent
	{
		IReadOnlyCollection<IEvent> GetNonPersistedEvents();
	}
}
