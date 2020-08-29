#pragma checksum "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ae911c291f0a9e0246d7a4225c51ca852508e9"
// <auto-generated/>
#pragma warning disable 1591
namespace Extensions
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Leah\source\repos\PizzaParty\Extensions\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
using Microsoft.AspNetCore.Blazor;

#line default
#line hidden
#line 2 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
using System.ComponentModel;

#line default
#line hidden
    public class ValidationErrors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
 if (Errors.Any())
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "validation-error");
            __builder.AddMarkupContent(3, "\r\n");
#line 7 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
         foreach (string error in Errors)
        {

#line default
#line hidden
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "li");
            __builder.AddContent(6, 
#line 9 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
                 error

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#line 10 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
        }

#line default
#line hidden
            __builder.AddContent(8, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 12 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"


}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 17 "C:\Users\Leah\source\repos\PizzaParty\Extensions\ValidationErrors.razor"
      
[Parameter]
public object Subject {get; set;}
[Parameter]
public string Property {get; set;}

public IEnumerable<string>
    Errors
    {
    get
    {
    switch (Subject)
    {
    case null:
    yield return $"{nameof(Subject)} has not been set!";
    yield break;
    case INotifyDataErrorInfo ine:
    if (Property == null){
    yield return $" {nameof(Property)} has not been set!";
    yield break;
    }
    foreach (var err in ine.GetErrors(Property)){
    yield return (string)err;
    }
    break;
    case IDataErrorInfo ide:
    if (Property == null){
    yield return $"{nameof(Property)} has not been set!";
    yield break;
    }
    string error = ide[Property];
    if(error !=null){
    yield return error;
    }
    else
    {
    yield break;
    }
    break;
    }
    }
    }
    

#line default
#line hidden
    }
}
#pragma warning restore 1591