#pragma checksum "C:\Users\pc\Desktop\BlzLogin\BlzLogin\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29d2c3597586301a7d2a60473ce301fbac2e3c073285f5e711292f56b0c16193"
// <auto-generated/>
#pragma warning disable 1591
namespace BlzLogin.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using BlzLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pc\Desktop\BlzLogin\BlzLogin\_Imports.razor"
using BlzLogin.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((AuthenticationState) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h1>Inicio</h1>\r\n        ");
                __builder2.AddMarkupContent(3, "<h2>Bienvenido a la aplicación</h2>");
            }
            ));
            __builder.AddAttribute(4, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<h2>Debe identificarse para poder acceder a la aplicación</h2>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
