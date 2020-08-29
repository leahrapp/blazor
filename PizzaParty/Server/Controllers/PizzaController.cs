using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaParty.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizzaParty.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private static List<Pizza> pizzas = new List<Pizza>
    {
        new Pizza(1, "Peperoni", 8.99M, Spiciness.Spicy),
        new Pizza(2, "Margarity", 7.99M, Spiciness.None),
        new Pizza(3, "Diablo", 9.99M, Spiciness.Hot)

                };
        [HttpGet("pizzas")]
        public IQueryable<Pizza> GetPizzas()
        {
            return pizzas.AsQueryable(); 
        }
}
}