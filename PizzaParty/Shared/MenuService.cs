using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; 

namespace PizzaParty.Shared
{
   public class MenuService : IMenuService
    {
        public Task<Menu> GetMenu()
        {
            return Task.FromResult<Menu>(new Menu
            {
                Pizzas = new List<Pizza>
    {
        new Pizza (1, "Peperoni", 8.99M, Spiciness.Spicy),
        new Pizza (2, "Margarity", 7.99M, Spiciness.None),
        new Pizza (3, "Diablo", 9.99M, Spiciness.Hot)

                }
            });
        }
    }
}
