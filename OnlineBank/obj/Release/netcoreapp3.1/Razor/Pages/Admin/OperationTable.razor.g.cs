#pragma checksum "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ef941de62e98e465c0d47252175dc45cd5c2ba"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineBank.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\_Imports.razor"
using OnlineBank.Models;

#line default
#line hidden
#nullable disable
    public partial class OperationTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.OpenElement(2, "thead");
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "th");
            __builder.AddAttribute(5, "colspan", "5");
            __builder.AddAttribute(6, "class", "text-center");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 7 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
         if (Operations?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
             foreach (Operation o in Operations)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 12 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                         o.AccountName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 13 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                         o.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<th>Account</th>\r\n                    ");
            __builder.AddMarkupContent(18, "<th>Amount</th>\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                                            e => OperationSelected.InvokeAsync(o.OperationID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, 
#nullable restore
#line 19 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                             ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                 foreach (Transfer.TransferLine line in o.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "<td colspan=\"2\"></td>\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 27 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                             line.Account.AccountName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 28 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                             line.Account.Balance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        <td></td>");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<tr><td colspan=\"5\" class=\"text-center\">No Operations</td></tr>");
#nullable restore
#line 37 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\OperationTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Operations";
    [Parameter]
    public IEnumerable<Operation> Operations { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Approve";
    [Parameter]
    public EventCallback<int> OperationSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
