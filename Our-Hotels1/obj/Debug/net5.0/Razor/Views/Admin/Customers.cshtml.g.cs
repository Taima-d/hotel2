#pragma checksum "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30813d33572895bad97514efa989f0552b070a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Customers), @"mvc.1.0.view", @"/Views/Admin/Customers.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using Our_Hotels1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using Our_Hotels1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using OurHotels.Dto.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using Our_Hotels1.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using My_Tables.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using OurHotels.Dto.Hotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using OurHotels.Dto.Room;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\_ViewImports.cshtml"
using OurHotels.Dto.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30813d33572895bad97514efa989f0552b070a0a", @"/Views/Admin/Customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02759191e9722b3100014b42ca3e0a7d0e14ffa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OurHotels.Dto.Customer.CustomerDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OpreationButtonPartialCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content container-fluid"">

    <!-- Page Header -->
    <div class=""page-header"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <h3 class=""page-title"">Welcome Admin!</h3>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item active"">Customers</li>
                </ul>
            </div>
        </div>
    </div>
    <!-- /Page Header -->
    <!-- Recent Orders -->
    <div class=""card card-table flex-fill"">
        <div class=""card-header"">
            <h4 class=""card-title"">Customers List</h4>
        </div>
        <div class=""card-body"">
            <div class=""table-responsifve"">
                <table class=""table table-hover table-center mb-0"">
                    <thead>
                        <tr>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>phone Number</th>
                            <th>Gender</th>
             ");
            WriteLiteral("               <th>Identity Certificate</th>\r\n                            <th>Customer\'s Birthday</th>\r\n                          \r\n\r\n                        </tr>\r\n                    </thead>\r\n");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> ");
#nullable restore
#line 42 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                            Write(Html.DisplayFor(m => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                            Write(Html.DisplayFor(m => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                            Write(Html.DisplayFor(m => item.phoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 45 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                            Write(Html.DisplayFor(m => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                            Write(Html.DisplayFor(m => item.Identity_Certificate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                            Write(Html.DisplayFor(m => item.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"width:15px\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30813d33572895bad97514efa989f0552b070a0a8588", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.CustomerEntityId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2283, "", 2422, 11);
#nullable restore
#line 56 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Admin\Customers.cshtml"
WriteAttributeValue("", 2290, Url.Action("CreateC", "Admin"), 2290, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2321, ">Add", 2321, 4, true);
            WriteAttributeValue(" ", 2325, "New</a>", 2326, 8, true);
            WriteAttributeValue("\r\n\r\n            ", 2333, "</div>", 2349, 22, true);
            WriteAttributeValue("\r\n        ", 2355, "</div>", 2365, 16, true);
            WriteAttributeValue("\r\n    ", 2371, "</div>", 2377, 12, true);
            WriteAttributeValue("\r\n    ", 2383, "<!--", 2389, 10, true);
            WriteAttributeValue(" ", 2393, "/Recent", 2394, 8, true);
            WriteAttributeValue(" ", 2401, "Orders", 2402, 7, true);
            WriteAttributeValue(" ", 2408, "-->", 2409, 4, true);
            WriteAttributeValue("\r\n\r\n", 2412, "</div>", 2416, 10, true);
            EndWriteAttribute();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OurHotels.Dto.Customer.CustomerDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591