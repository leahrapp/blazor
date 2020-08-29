#pragma checksum "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da27eb71ce94343cb100166b4b5f89ef657f2b31"
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
#line 2 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\Index.razor"
using PizzaParty.Shared;

#line default
#line hidden
#line 3 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#line 4 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 27 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\Index.razor"
       
    private State State { get; } = new State();

    protected override async Task OnInitializedAsync()
    {
        State.Menu = await menuService.GetMenu();
        this.State.Basket.Customer.PropertyChanged += (sender, e) => this.StateHasChanged();
    }
    private void AddToBasket (Pizza pizza)
    {
        Console.WriteLine($"Added { pizza.Name}");
        State.Basket.Add(pizza.Id);
        StateHasChanged();
    }

    private void RemoveFromBasket(int pos)
    {
        State.Basket.RemoveAt(pos);
        StateHasChanged();
    }

    private async Task PlaceOrder()
    {

        await orderService.PlaceOrder(State.Basket);
    }
    protected override void OnInitialized()
    {
        this.State.Basket.Customer.PropertyChanged += (sender, e) => this.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMenuService menuService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService orderService { get; set; }
    }
}
#pragma warning restore 1591