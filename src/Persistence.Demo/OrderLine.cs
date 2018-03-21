using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Demo
{
    public class OrderLine
    {
		public int ItemId { get; }
		public int Quantity { get; private set; }

		public  int Price { get; }
		
	    public OrderLine(int itemId, int quantity, int price)
	    {
		    ItemId = itemId;
		    Quantity = quantity;
		    Price = price;
	    }

	    public void UpdateQuantity(int newQuantity)
	    {
		    Quantity = Quantity;
	    }
    }
}
