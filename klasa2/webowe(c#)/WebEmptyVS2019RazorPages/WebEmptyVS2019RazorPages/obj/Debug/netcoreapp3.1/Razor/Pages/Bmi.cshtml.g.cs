#pragma checksum "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380ccfacb4689b19aedc765ff9ce7c6f27124b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebEmptyVS2019RazorPages.Pages.Pages_Bmi), @"mvc.1.0.razor-page", @"/Pages/Bmi.cshtml")]
namespace WebEmptyVS2019RazorPages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380ccfacb4689b19aedc765ff9ce7c6f27124b40", @"/Pages/Bmi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a1b4e3eb8cc49e61ecc19eb0b64fd85c06fe5d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Bmi : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Współczynnik BMI</h1>\n<!--TODO formularz oraz obliczenie BMI-->\n<div class=\"content\">\n    <div class=\"baner\"><div>Obliczanie współczynnika BMI </div><img src=\"media/bmi.jpg\" alt=\"obrazek BMI\" /></div>\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380ccfacb4689b19aedc765ff9ce7c6f27124b403416", async() => {
                WriteLiteral(@"
            <div class=""line"">
                <label for=""masa"">Podaj masę: </label>
                <input type=""number"" name=""masa"" id=""masa"" required step=""0.1"" min=""1"" max=""300""/>
                <span>kg</span>
            </div>
            <div class=""line"">
                <label for=""wzrost"">Podaj wzrost: </label>
                <input type=""number"" name=""wzrost"" id=""wzrost"" required min=""10"" max=""290""/>
                <span>cm</span>
            </div>
            <div>
                <label>Wybierz płeć: </label><br/>
                <input type=""radio"" name=""plec"" value=""Kobieta"" checked/>Kobieta<br/>
                <input type=""radio"" name=""plec"" value=""Mężczyzna""/>Mężczyzna<br/>
            </div>
            <input type=""submit"" value=""Oblicz""/>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 29 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
     if (Model.IsPost) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\n            <div>Obliczony współczynnik BMI: ");
#nullable restore
#line 31 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
                                        Write(Model.BMI);

#line default
#line hidden
#nullable disable
            WriteLiteral(" co daje nam: ");
#nullable restore
#line 31 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
                                                                Write(Model.Description());

#line default
#line hidden
#nullable disable
            WriteLiteral(" dla płci: ");
#nullable restore
#line 31 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
                                                                                               Write(Model.Plec);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 32 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
             if (@Model.BMI < 18.5) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"media/niedowaga.jpg\" alt=\"niedowaga\"/>\n");
#nullable restore
#line 34 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
            }else if (@Model.BMI >= 18.5 && @Model.BMI < 25) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"media/normana.jpg\" alt=\"norma\"/>\n");
#nullable restore
#line 36 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"media/nadwaga.jpg\" alt=\"nadwaga\"/>\n");
#nullable restore
#line 39 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n");
#nullable restore
#line 41 "C:\Users\Stach\Desktop\git\klasa2\webowe(c#)\WebEmptyVS2019RazorPages\WebEmptyVS2019RazorPages\Pages\Bmi.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebEmptyVS2019RazorPages.Pages.BmiModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebEmptyVS2019RazorPages.Pages.BmiModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebEmptyVS2019RazorPages.Pages.BmiModel>)PageContext?.ViewData;
        public WebEmptyVS2019RazorPages.Pages.BmiModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
