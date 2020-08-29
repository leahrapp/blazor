using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; 
namespace PizzaParty.Shared
{
    public class OrderService : IOrderService
    {
        public Task PlaceOrder(Basket basket)
        {
            return Task.CompletedTask; 
        }
    }
}
