using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persisted.Events
{
	public abstract class EventDispatcher
	{
		public void DispatchAll(IReadOnlyCollection<IEvent> events)
		{
			foreach (var @event in events)
			{
				Dispatch(@event);
			}
		}

		protected abstract void Dispatch(IEvent @event);
		
		/// <summary>
		/// Fallback handler, use dynamic to 
		/// </summary>
		/// <param name="event"></param>
		protected virtual void Handle(IEvent @event)
		{
			Console.WriteLine("Fallback handler called.. Log.this");
		}
	}
}
