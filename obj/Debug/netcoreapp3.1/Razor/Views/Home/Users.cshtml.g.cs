#pragma checksum "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1fb4d2a30a640d077a6ca2651e4f38ab34eedf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/_ViewImports.cshtml"
using viewmodel_fun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/_ViewImports.cshtml"
using viewmodel_fun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fb4d2a30a640d077a6ca2651e4f38ab34eedf8", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f090c89d8709f9949e3e4b908f3bcc530e8402d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/Home/Users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <h1>Here are some users!</h1>\n    <ul>\n");
#nullable restore
#line 9 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/Home/Users.cshtml"
         foreach (User user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 11 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/Home/Users.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/Home/Users.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 12 "/Users/dustincrawford/Documents/CodingDojo/csharp_stack/asp_net_core/viewmodel_fun/Views/Home/Users.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
