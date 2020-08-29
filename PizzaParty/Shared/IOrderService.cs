using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaParty.Shared
{
    public interface IOrderService
    {
        Task PlaceOrder(Basket basket); 
    }
}
