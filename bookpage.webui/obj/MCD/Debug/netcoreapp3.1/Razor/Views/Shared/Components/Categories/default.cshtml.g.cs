#pragma checksum "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\Shared\Components\Categories\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8f22736f28775b5d612020459fa8b76860f389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/default.cshtml")]
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
#line 1 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\_ViewImports.cshtml"
using bookpage.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\_ViewImports.cshtml"
using bookpage.webui.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8f22736f28775b5d612020459fa8b76860f389", @"/Views/Shared/Components/Categories/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0210e10eaa0fcc1d146f16fa689083bc122cedfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"list-group\">\r\n<a href=\"/product/list\" class=\"list-group-item list-group-item-action\">Tüm Kategoriler</a>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\Shared\Components\Categories\default.cshtml"
                       foreach (var category in Model)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <a");
            BeginWriteAttribute("href", " href= \"", 248, "\"", 290, 2);
            WriteAttributeValue("", 256, "/product/list/", 256, 14, true);
#nullable restore
#line 7 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\Shared\Components\Categories\default.cshtml"
WriteAttributeValue("", 270, category.CategoryId, 270, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " \r\n                      class=\"", 291, "\"", 435, 3);
            WriteAttributeValue("", 323, "list-group-item", 323, 15, true);
            WriteAttributeValue(" ", 338, "list-group-item-action", 339, 23, true);
#nullable restore
#line 8 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\Shared\Components\Categories\default.cshtml"
WriteAttributeValue(" ", 361, ViewBag.SelectedCategory == category.CategoryId.ToString()?"active":"", 362, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                      ");
#nullable restore
#line 9 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\Shared\Components\Categories\default.cshtml"
                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>                  \r\n");
#nullable restore
#line 10 "C:\Users\Ahmet Karadağ\Desktop\bookpage\bookpage.webui\Views\Shared\Components\Categories\default.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
