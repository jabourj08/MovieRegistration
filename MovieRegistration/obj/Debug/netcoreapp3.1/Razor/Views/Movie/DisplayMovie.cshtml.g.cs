#pragma checksum "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82ad317f827e78d4ecaaff3adc55bdf427b7767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DisplayMovie), @"mvc.1.0.view", @"/Views/Movie/DisplayMovie.cshtml")]
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
#line 1 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e82ad317f827e78d4ecaaff3adc55bdf427b7767", @"/Views/Movie/DisplayMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DisplayMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
  
    ViewData["Title"] = "Display Movie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Added Movie</h1>\r\n\r\n<p>\r\n    <b>Movie Title:</b> ");
#nullable restore
#line 11 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Genre:</b> ");
#nullable restore
#line 12 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
             Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Year Released:</b> ");
#nullable restore
#line 13 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
                     Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
            WriteLiteral("    <b>Actors:</b>\r\n");
#nullable restore
#line 16 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
     foreach (string a in Model.Actors)
    {
        if (Model.Actors.IndexOf(a) < Model.Actors.Count - 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 20 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
             Write(Html.DisplayFor(item => a));

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n");
#nullable restore
#line 21 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 24 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
             Write(Html.DisplayFor(item => a));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 25 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Directors:</b>\r\n");
#nullable restore
#line 29 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
     foreach (string a in Model.Directors)
    {
        if (Model.Directors.IndexOf(a) < Model.Directors.Count - 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 33 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
             Write(Html.DisplayFor(item => a));

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n");
#nullable restore
#line 34 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 37 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
             Write(Html.DisplayFor(item => a));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 38 "C:\Users\Josh\source\repos\MovieRegistration\MovieRegistration\Views\Movie\DisplayMovie.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
