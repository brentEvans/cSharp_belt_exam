#pragma checksum "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99620c6e366ae79dc2bba9df9056be5d5a2a16e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99620c6e366ae79dc2bba9df9056be5d5a2a16e", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 245, true);
            WriteLiteral("\n<nav class=\"navbar navbar-expand-lg navbar-light bg-white row\">\n    <div class=\"navbar-brand text-secondary col-xs-3\" style=\"font-size: 1.4rem\"><strong>Dojo Activity Center</strong></div>\n\n    <div class=\"col-xs-2 offset-1\">\n        <p>Welcome ");
            EndContext();
            BeginContext(246, 22, false);
#line 6 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
              Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(268, 467, true);
            WriteLiteral(@"</p>
    </div>

    <div class=""col-xs-2 offset-1"">
        <a href=""/logout"">Logout</a>
    </div>
</nav>






<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Activity</th>
            <th scope=""col"">Date and Time</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Event Coordinator</th>
            <th scope=""col"">Number of Participants</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
");
            EndContext();
#line 30 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
         foreach (var e in ViewBag.allEvents)
        {
            DateTime now = DateTime.Now;

            if (e.Date.CompareTo(now) < 0){
                continue;
            }

#line default
#line hidden
            BeginContext(917, 52, true);
            WriteLiteral("            <tr>\n                <th scope =\"row\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 969, "\"", 993, 2);
            WriteAttributeValue("", 976, "/Event/", 976, 7, true);
#line 38 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 983, e.EventId, 983, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(994, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(996, 7, false);
#line 38 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                                                        Write(e.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 30, true);
            WriteLiteral("</a></th>\n                <td>");
            EndContext();
            BeginContext(1034, 6, false);
#line 39 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
               Write(e.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(1045, 6, false);
#line 39 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                          Write(e.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1078, 10, false);
#line 40 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
               Write(e.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1090, 15, false);
#line 40 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                           Write(e.DurationUnits);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1132, 23, false);
#line 41 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
               Write(e.Coordinator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1155, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1157, 22, false);
#line 41 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                                        Write(e.Coordinator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1206, 15, false);
#line 42 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
               Write(e.AttendeeCount);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 7, true);
            WriteLiteral("</td>\n\n");
            EndContext();
#line 44 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                 if (e.Coordinator.UserId == ViewBag.User.UserId)
                {

#line default
#line hidden
            BeginContext(1312, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1338, "\"", 1368, 3);
            WriteAttributeValue("", 1345, "event/", 1345, 6, true);
#line 46 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 1351, e.EventId, 1351, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1361, "/delete", 1361, 7, true);
            EndWriteAttribute();
            BeginContext(1369, 17, true);
            WriteLiteral(">Delete</a></td>\n");
            EndContext();
#line 47 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 50 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                     if(!ViewBag.allUserEvents.Contains(e))
                    {

#line default
#line hidden
            BeginContext(1525, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1555, "\"", 1583, 3);
            WriteAttributeValue("", 1562, "event/", 1562, 6, true);
#line 52 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 1568, e.EventId, 1568, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1578, "/join", 1578, 5, true);
            EndWriteAttribute();
            BeginContext(1584, 15, true);
            WriteLiteral(">Join</a></td>\n");
            EndContext();
#line 53 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                    }
                    else 
                    {

#line default
#line hidden
            BeginContext(1669, 30, true);
            WriteLiteral("                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1728, 3);
            WriteAttributeValue("", 1706, "event/", 1706, 6, true);
#line 56 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 1712, e.EventId, 1712, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1722, "/leave", 1722, 6, true);
            EndWriteAttribute();
            BeginContext(1729, 16, true);
            WriteLiteral(">Leave</a></td>\n");
            EndContext();
#line 57 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                    }

#line default
#line hidden
#line 57 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1785, 18, true);
            WriteLiteral("            </tr>\n");
            EndContext();
#line 60 "/Users/brent/Desktop/Coding/c#_stack/ASP.NET_Core/BeltExam/Views/Home/Home.cshtml"
        }

#line default
#line hidden
            BeginContext(1813, 111, true);
            WriteLiteral("</table>\n\n\n\n\n\n\n<div class=\"float-right\"><a href=\"/new\" class=\"btn btn-warning\">Add a new Activity!</a></div>\n\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591