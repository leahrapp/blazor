using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; 
namespace PizzaParty.Shared
{
   public interface IMenuService
    {
        Task<Menu> GetMenu(); 
    }
}
