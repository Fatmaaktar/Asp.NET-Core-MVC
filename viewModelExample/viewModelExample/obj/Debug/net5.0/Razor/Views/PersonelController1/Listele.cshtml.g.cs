#pragma checksum "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\PersonelController1\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8443817540e0700dfc8966d358bbfe89e742d85e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonelController1_Listele), @"mvc.1.0.view", @"/Views/PersonelController1/Listele.cshtml")]
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
#line 1 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\_ViewImports.cshtml"
using viewModelExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\_ViewImports.cshtml"
using viewModelExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\_ViewImports.cshtml"
using viewModelExample.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8443817540e0700dfc8966d358bbfe89e742d85e", @"/Views/PersonelController1/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06954af088d373fff2aa7151029a52917efdec4", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonelController1_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonelListVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 4 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\PersonelController1\Listele.cshtml"
     foreach (var personel in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 7 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\PersonelController1\Listele.cshtml"
       Write(personel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\PersonelController1\Listele.cshtml"
                      Write(personel.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\PersonelController1\Listele.cshtml"
                                        Write(personel.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 9 "C:\Users\W10\source\repos\viewModelExample\viewModelExample\Views\PersonelController1\Listele.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonelListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
