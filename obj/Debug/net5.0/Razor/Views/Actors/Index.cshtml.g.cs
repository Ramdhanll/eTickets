#pragma checksum "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4091e2810506107f33c008a6d872a03604e55dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
#line 1 "C:\Ramadhani\Development\Website\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ramadhani\Development\Website\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4091e2810506107f33c008a6d872a03604e55dd", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
  
   ViewData["Title"] = "List of Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 84, "\"", 92, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding: 0px 150px;\">\r\n   <table class=\"table table-striped table-inverse \">\r\n      <thead class=\"thead-inverse\">\r\n         <tr class=\"text-center\">\r\n            <th>");
#nullable restore
#line 11 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 12 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 13 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Actions</th>\r\n         </tr>\r\n      </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 18 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
          foreach (var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n               <td class=\"align-middle\">\r\n                  <img");
            BeginWriteAttribute("src", " src=\"", 689, "\"", 718, 1);
#nullable restore
#line 22 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
WriteAttributeValue("", 695, item.ProfilePictureURL, 695, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 719, "\"", 739, 1);
#nullable restore
#line 22 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
WriteAttributeValue("", 725, item.FullName, 725, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle\" style=\"max-width: 80px;\">\r\n               </td>\r\n               <td class=\"align-middle\">\r\n                  ");
#nullable restore
#line 25 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
             Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               </td>\r\n               <td class=\"align-middle\">\r\n                  ");
#nullable restore
#line 28 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
             Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
               </td>
               <td class=""align-middle"">
                  <a class=""btn btn-primary"">
                     <i class=""fa-solid fa-eye text-white""></i>
                  </a> |
                  <a class=""btn btn-warning"">
                     <i class=""fa-solid fa-pen-to-square text-white""></i>
                  </a> |
                  <a class=""btn btn-danger"">
                     <i class=""fa-solid fa-trash text-white""></i>
                  </a>
               </td>
            </tr>
");
#nullable restore
#line 42 "C:\Ramadhani\Development\Website\eTickets\Views\Actors\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n   </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
