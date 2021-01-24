// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/accounts")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Accounts : OwningComponentBase<IBankRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\U\source\repos\OnlineBankSln\OnlineBank\Pages\Admin\Accounts.razor"
       
    public IBankRepository Repository => Service;
    public IEnumerable<Account> AccountData { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }
    public async Task UpdateData()
    {
        AccountData = await Repository.Accounts.ToListAsync();
    }

    public async Task DeleteAccount(Account a)
    {
        Repository.DeleteAccount(a);
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/accounts/details/{id}";
    public string GetEditUrl(long id) => $"/admin/accounts/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591