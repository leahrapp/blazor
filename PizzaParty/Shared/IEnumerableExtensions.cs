using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace PizzaParty.Shared
{
public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumberable) => enumberable.GetEnumerator().MoveNext() == true; 
    }
    
    
}
