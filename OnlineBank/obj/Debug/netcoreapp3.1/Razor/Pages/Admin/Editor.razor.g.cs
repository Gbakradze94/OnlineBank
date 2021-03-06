#pragma checksum "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9e9738da82bde67e2141ead2bb0be6ecd9c0e8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/accounts/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/accounts/create")]
    public partial class Editor : OwningComponentBase<IBankRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-message {\r\n        color: rgb(220, 53, 69);\r\n        font-weight: 500\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 10 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 10 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                                       TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " a Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                 Account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                         SaveAccount

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 13 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
     if (Account.AccountID != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<label>ID</label>\r\n            ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.AddAttribute(21, "value", 
#nullable restore
#line 17 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                                         Account.AccountID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 19 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label>Account Name</label>\r\n        ");
                __Blazor.OnlineBank.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 22 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                  () => Account.AccountName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                                     Account.AccountName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Account.AccountName = __value, Account.AccountName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Account.AccountName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    \r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<label>Category</label>\r\n        ");
                __Blazor.OnlineBank.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 33 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                  () => Account.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                                     Account.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Account.Category = __value, Account.Category))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Account.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<label>Balance</label>\r\n        ");
                __Blazor.OnlineBank.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 38 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                  () => Account.Balance

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n        ");
                __Blazor.OnlineBank.Pages.Admin.Editor.TypeInference.CreateInputNumber_3(__builder2, 60, 61, "form-control", 62, 
#nullable restore
#line 39 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                                       Account.Balance

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Account.Balance = __value, Account.Balance)), 64, () => Account.Balance);
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "type", "submit");
                __builder2.AddAttribute(69, "class", "btn" + " btn-" + (
#nullable restore
#line 41 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
                __builder2.AddAttribute(73, "class", "btn btn-secondary");
                __builder2.AddAttribute(74, "href", "/admin/products");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(76, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Editor.razor"
       
    public IBankRepository Repository => Service;
    [Inject]
    public NavigationManager NavManager { get; set; }
    [Parameter]
    public long Id { get; set; } = 0;
    public Account Account { get; set; } = new Account();
    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            Account = Repository.Accounts.FirstOrDefault(a => a.AccountID == Id);
        }
    }
    public void SaveAccount()
    {
        if (Id == 0)
        {
            Repository.CreateAccount(Account);
        }
        else
        {
            Repository.SaveAccount(Account);
        }
        NavManager.NavigateTo("/admin/accounts");
    }
    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.OnlineBank.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
