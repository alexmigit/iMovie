#pragma checksum "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4076965b79cf5f8252c92a5c88cc2b7ade0ff055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(iMovie.Pages.Home.Pages_Home_About), @"mvc.1.0.razor-page", @"/Pages/Home/About.cshtml")]
namespace iMovie.Pages.Home
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
#line 1 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\_ViewImports.cshtml"
using iMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4076965b79cf5f8252c92a5c88cc2b7ade0ff055", @"/Pages/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2eb431afd5a653d95ee2e7c278a54951d380f7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Home_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>About iMovie</h1>\r\n\r\n<blockquote class=\"blockquote text-left\">\r\n");
#nullable restore
#line 10 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
      
        var quote = "The future depends on what you do today. - Mahatma Gandhi";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"mb-0\">");
#nullable restore
#line 13 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
               Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <footer class=\"blockquote-footer\">Mahatma Gandhi <cite title=\"Source Title\">(The Internet)</cite></footer>\r\n</blockquote>\r\n\r\n<blockquote class=\"blockquote text-left\">\r\n");
#nullable restore
#line 18 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
      
        quote = "Hate cannot drive out hate, only love can do that.";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"mb-0\">");
#nullable restore
#line 21 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
               Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <footer class=\"blockquote-footer\">Martin Luther King, Jr. <cite title=\"Source Title\">(The Internet)</cite></footer>\r\n</blockquote>\r\n\r\n<blockquote class=\"blockquote text-left\">\r\n");
#nullable restore
#line 26 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
      
        quote = "If builders built buildings the way programmers wrote programs, then the first woodpecker that came along would destroy civilization.";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"mb-0\">");
#nullable restore
#line 29 "C:\Users\info\OneDrive\space\Web Development\App\iMovie\iMovie\Pages\Home\About.cshtml"
               Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <footer class=\"blockquote-footer\">Weiberg\'s Second Law <cite title=\"Source Title\">(The Internet)</cite></footer>\r\n</blockquote>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iMovie.AboutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iMovie.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<iMovie.AboutModel>)PageContext?.ViewData;
        public iMovie.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
