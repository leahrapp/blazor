using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PizzaParty.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public Pizza GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id); 
    }
}
