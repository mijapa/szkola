#pragma checksum "D:\zdalne\zdalneNiepo2020\webowe2tiGim\Cw2Empty\Pages\Nowa1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb18b36f02e2c4ad868b06021a71bbf9bd1f2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cw2Empty.Pages_Nowa1), @"mvc.1.0.razor-page", @"/Pages/Nowa1.cshtml")]
namespace Cw2Empty
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb18b36f02e2c4ad868b06021a71bbf9bd1f2b0", @"/Pages/Nowa1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccc86e67baac7701b42bc6405eebf9bd73007e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Nowa1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Pierwsza podstrona</h3>\r\n<div>\r\n    <ol>\r\n");
#nullable restore
#line 8 "D:\zdalne\zdalneNiepo2020\webowe2tiGim\Cw2Empty\Pages\Nowa1.cshtml"
         foreach (var kwiat in Model.Kwiaty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 10 "D:\zdalne\zdalneNiepo2020\webowe2tiGim\Cw2Empty\Pages\Nowa1.cshtml"
           Write(kwiat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "D:\zdalne\zdalneNiepo2020\webowe2tiGim\Cw2Empty\Pages\Nowa1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cw2Empty.Nowa1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cw2Empty.Nowa1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cw2Empty.Nowa1Model>)PageContext?.ViewData;
        public Cw2Empty.Nowa1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
