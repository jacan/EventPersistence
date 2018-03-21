using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persisted.Events
{
	public interface IEventRepository<T> where T : class
	{
		T GetById(int id);
		IEnumerable<T> GetAll();

		void Store(T itemToStore);
	}
}
