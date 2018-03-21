using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Demo;

namespace Persistence.AppDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var order = Order.CreateOrder();

			order.AddToOrder(new OrderLine(1, 10, 25));
			order.AddToOrder(new OrderLine(2, 200, 1));
			order.UpdateOrderLineQuantity(1, 30);
			order.UpdateOrderLineQuantity(222, -1);
			order.DeleteOrder();

			var orderRepository = new OrderRepository();

			orderRepository.Store(order);
		}
	}
}
