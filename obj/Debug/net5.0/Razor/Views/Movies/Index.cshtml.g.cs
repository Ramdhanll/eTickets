#pragma checksum "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4047b67a9067759ead06e12e767d47ec4e560c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4047b67a9067759ead06e12e767d47ec4e560c0", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
  
   ViewData["Title"] = "List of Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pt-3\">\r\n   <div class=\"row px-5 \">\r\n");
#nullable restore
#line 9 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"col-xl-3 col-lg-4 col-md-4 col-sm-6 col-xs-12 rounded mb-5\">\r\n            <div class=\"card\" style=\"width: 19rem; \">\r\n               <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 351, "\"", 371, 1);
#nullable restore
#line 13 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 357, item.ImageURL, 357, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n               <div class=\"card-body\">\r\n                  <div class=\"d-flex justify-content-between mb-3\">\r\n                     <h5 class=\"pt-1 card-title align-self-center\">");
#nullable restore
#line 16 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                     <button class=\"btn btn-outline-warning\">\r\n                        <i class=\"fas fa-edit    \"></i>\r\n                     </button>\r\n                  </div>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <ul class=\"list-group list-group-flush\">\r\n                     <li class=\" list-group-item \">\r\n                        <strong>Cinema: </strong>\r\n                        ");
#nullable restore
#line 25 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                   Write(item.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </li>\r\n                     <li class=\" list-group-item\">\r\n                        <strong>Category: </strong>\r\n                        ");
#nullable restore
#line 29 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                   Write(item.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </li>\r\n                     <li class=\"list-group-item\">\r\n                        <strong>Start Date: </strong>\r\n                        ");
#nullable restore
#line 33 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                   Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </li>\r\n                     <li class=\"list-group-item\">\r\n                        <strong>End Date: </strong>\r\n                        ");
#nullable restore
#line 37 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                   Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </li>\r\n                     <li class=\"list-group-item\">\r\n                        <strong>Status: </strong>\r\n");
#nullable restore
#line 41 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                         if (DateTime.Now >= item.StartDate && DateTime.Now <= item.EndDate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <span class=\"badge bg-success text-white\">AVAILABLE</span>\r\n");
#nullable restore
#line 44 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <span class=\"badge bg-primary text-white\">UPCOMING</span>\r\n");
#nullable restore
#line 48 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                     </li>
                  </ul>
               </div>
               <div class=""card-footer"">
                  <div class=""d-flex justify-content-between mb-3"">
                     <button class=""btn btn-outline-success"">
                        <i class=""fa fa-cart-plus"" aria-hidden=""true""></i>
                     </button>
                     <button class=""btn btn-outline-primary"">
                        <i class=""fa fa-eye"" aria-hidden=""true""></i> Show Detail
                     </button>
                  </div>
               </div>
            </div>
         </div>
");
#nullable restore
#line 64 "C:\Ramadhani\Development\Website\eTickets\Views\Movies\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
