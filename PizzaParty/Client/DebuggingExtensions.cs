using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;  
using System.Threading.Tasks;


namespace PizzaParty.Client
{
    public static class DebuggingExtensions
    {
        public static string ToJson(this object obj) => System.Text.Json.JsonSerializer.Serialize(obj); 
    }
}
