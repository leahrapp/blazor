#pragma checksum "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31cefc64f1fc866abd452780ba2c28ec090d2c0c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
using PizzaParty.Shared;

#line default
#line hidden
#line 2 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
using Extensions;

#line default
#line hidden
    public class CustomerEntry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "fieldset");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n            ");
            __builder.AddMarkupContent(4, "<label for=\"name\">Name: </label>\r\n            ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "id", "name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 7 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                     Customer.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Customer.Name = __value, Customer.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n           ");
            __builder.OpenComponent<Extensions.ValidationErrors>(10);
            __builder.AddAttribute(11, "Subject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 8 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                       Customer

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "Property", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 8 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                                            nameof(Customer.Name)

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<label for=\"street\">Street:</label>\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "id", "street");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 12 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                       Customer.Street

#line default
#line hidden
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Customer.Street = __value, Customer.Street));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenComponent<Extensions.ValidationErrors>(23);
            __builder.AddAttribute(24, "Subject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 13 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                        Customer

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "Property", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 13 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                                             nameof(Customer.Street)

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "p");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddMarkupContent(30, "<label for=\"city\">City:</label>\r\n            ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "id", "city");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 17 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                     Customer.City

#line default
#line hidden
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Customer.City = __value, Customer.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenComponent<Extensions.ValidationErrors>(36);
            __builder.AddAttribute(37, "Subject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 18 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                        Customer

#line default
#line hidden
            ));
            __builder.AddAttribute(38, "Property", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                                             nameof(Customer.City)

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                            ()=>Submit(Customer)

#line default
#line hidden
            ));
            __builder.AddAttribute(43, "disabled", 
#line 22 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
                                                              Customer.HasErrors

#line default
#line hidden
            );
            __builder.AddContent(44, "Checkout");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 25 "C:\Users\Leah\source\repos\PizzaParty\PizzaParty\Client\Pages\CustomerEntry.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public Customer Customer { get; set; }

    [Parameter]
    public Action<Customer> Submit { get; set; }
    [Parameter]
    public Action<Customer> CustomerChanged { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
