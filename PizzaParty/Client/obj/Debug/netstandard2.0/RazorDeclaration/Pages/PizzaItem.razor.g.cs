#pragma checksum "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\PizzaItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d730fe4c1920a52400c475d3928cb7674c71631c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PizzaParty.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using PizzaParty.Client;

#line default
#line hidden
#line 7 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\_Imports.razor"
using PizzaParty.Client.Shared;

#line default
#line hidden
#line 1 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\PizzaItem.razor"
using PizzaParty.Shared;

#line default
#line hidden
    public class PizzaItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 16 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\PizzaItem.razor"
       
    [Parameter]
    public Pizza Pizza { get; set; }
    [Parameter]
    public string ButtonTitle { get; set; }

    [Parameter]
    public string ButtonClass { get; set;  }
    [Parameter]
    public string ButtonText { get; set; }

    [Parameter]
    public Action<Pizza> Selected { get; set; }

    private string SpicinessImage(Spiciness spiciness) => $"img/{spiciness.ToString().ToLower()}.jpg";

#line default
#line hidden
    }
}
#pragma warning restore 1591