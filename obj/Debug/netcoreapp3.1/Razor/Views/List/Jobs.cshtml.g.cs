#pragma checksum "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04cab9cb8b1a7d932b112cecab0b5d7a8714840a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Jobs), @"mvc.1.0.view", @"/Views/List/Jobs.cshtml")]
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
#line 1 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\_ViewImports.cshtml"
using TechJobsMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\_ViewImports.cshtml"
using TechJobsMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04cab9cb8b1a7d932b112cecab0b5d7a8714840a", @"/Views/List/Jobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72d03d81c67881119915eb609de8383c31df3ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_List_Jobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container body-content\">\n\n    <h1>");
#nullable restore
#line 3 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
   Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n\n");
#nullable restore
#line 7 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
     foreach (var job in ViewBag.jobs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"job-listing\">\n            <tr><td>ID</td><td>");
#nullable restore
#line 10 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
                          Write(job.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n            <tr><td>Name</td><td>");
#nullable restore
#line 11 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
                            Write(job.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n            <tr><td>Employer</td><td>");
#nullable restore
#line 12 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
                                Write(job.Employer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n            <tr><td>Location</td><td>");
#nullable restore
#line 13 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
                                Write(job.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n            <tr><td>Position Type</td><td>");
#nullable restore
#line 14 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
                                     Write(job.PositionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n            <tr><td>Skill</td><td>");
#nullable restore
#line 15 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
                             Write(job.CoreCompetency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n        </table>\n");
#nullable restore
#line 17 "C:\Users\mhenk\OneDrive\Documents\Koby School\TechJobsMVC-master\TechJobsMVC\Views\List\Jobs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
