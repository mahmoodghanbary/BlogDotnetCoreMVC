#pragma checksum "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d69778b39a94aadb3ff7316e04a4e801583ee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PageGroup_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PageGroup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60d69778b39a94aadb3ff7316e04a4e801583ee0", @"/Areas/Admin/Views/PageGroup/Index.cshtml")]
    public class Areas_Admin_Views_PageGroup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLayer.Models.PageGroups>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GroupTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GroupTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 584, "\"", 612, 1);
#nullable restore
#line 28 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
WriteAttributeValue("", 599, item.GroupID, 599, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 665, "\"", 693, 1);
#nullable restore
#line 29 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
WriteAttributeValue("", 680, item.GroupID, 680, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 748, "\"", 776, 1);
#nullable restore
#line 30 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
WriteAttributeValue("", 763, item.GroupID, 763, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "/home/mahmood/Public/mahmood/blog/BlogDotnetCoreMVC/Blog/Areas/Admin/Views/PageGroup/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLayer.Models.PageGroups>> Html { get; private set; }
    }
}
#pragma warning restore 1591