#pragma checksum "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b277a0b4bcac5033dfb0a05e21af3a923800cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_SearchHotel), @"mvc.1.0.view", @"/Views/Customer/SearchHotel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b277a0b4bcac5033dfb0a05e21af3a923800cf4", @"/Views/Customer/SearchHotel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02759191e9722b3100014b42ca3e0a7d0e14ffa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_SearchHotel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OurHotels.Dto.Customer.RoomDetailsDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-select2-id", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sorting"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Room Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
  
	Layout = "_Layout";
	string l = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumb-bar"">
				<div class=""container-fluid"">
					<div class=""row align-items-center"">
						<div class=""col-md-8 col-12"">
							<nav aria-label=""breadcrumb"" class=""page-breadcrumb"">
								<ol class=""breadcrumb"">
									<li class=""breadcrumb-item""><a href=""index-2.html"">Home</a></li>
									<li class=""breadcrumb-item active"" aria-current=""page"">Search</li>
								</ol>
							</nav>
							<h2 class=""breadcrumb-title"">2245 matches found for : Dentist In Bangalore</h2>
						</div>
						<div class=""col-md-4 col-12 d-md-block d-none"">
							<div class=""sort-by"">
								<span class=""sort-title"">Sort by</span>
								<span class=""sortby-fliter"">
									<select class=""select select2-hidden-accessible"" data-select2-id=""1"" tabindex=""-1"" aria-hidden=""true"">
										");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b277a0b4bcac5033dfb0a05e21af3a923800cf47197", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b277a0b4bcac5033dfb0a05e21af3a923800cf48258", async() => {
                WriteLiteral("Rating");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b277a0b4bcac5033dfb0a05e21af3a923800cf49319", async() => {
                WriteLiteral("Popular");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b277a0b4bcac5033dfb0a05e21af3a923800cf410381", async() => {
                WriteLiteral("Latest");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b277a0b4bcac5033dfb0a05e21af3a923800cf411443", async() => {
                WriteLiteral("Free");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
									</select><span class=""select2 select2-container select2-container--default"" dir=""ltr"" data-select2-id=""2"" style=""width: 100%;""><span class=""selection""><span class=""select2-selection select2-selection--single"" role=""combobox"" aria-haspopup=""true"" aria-expanded=""false"" tabindex=""0"" aria-disabled=""false"" aria-labelledby=""select2-uuqs-container""><span class=""select2-selection__rendered"" id=""select2-uuqs-container"" role=""textbox"" aria-readonly=""true"" title=""Select"">Select</span><span class=""select2-selection__arrow"" role=""presentation""><b role=""presentation""></b></span></span></span><span class=""dropdown-wrapper"" aria-hidden=""true""></span></span>
								</span>
							</div>
						</div>
					</div>
				</div>
			</div>
			<div class=""content"" style=""transform: none; min-height: 128.5px;"">
				<div class=""container-fluid"" style=""transform: none;"">

					<div class=""row"" style=""transform: none;"">
						<div class=""col-md-12 col-lg-4 col-xl-3 theiaStickySidebar"" style=""position: relative; over");
            WriteLiteral(@"flow: visible; box-sizing: border-box; min-height: 1px;"">
						
							<!-- Search Filter -->
							
							<!-- /Search Filter -->
							
						<div class=""theiaStickySidebar"" style=""padding-top: 0px; padding-bottom: 1px; position: static; transform: none; left: 20px; top: 0px;""><div class=""card search-filter"">
								<div class=""card-header"">
									<h4 class=""card-title mb-0"">Search Filter</h4>
								</div>
								<div class=""card-body"">
								<div class=""filter-widget"">
									<div class=""cal-icon"">
										<input type=""text"" class=""form-control datetimepicker"" placeholder=""Select Date"">
									</div>			
								</div>
								<div class=""filter-widget"">
									<h4>Gender</h4>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""gender_type""");
            BeginWriteAttribute("checked", " checked=\"", 3026, "\"", 3036, 0);
            EndWriteAttribute();
            WriteLiteral(@">
											<span class=""checkmark""></span> Male Doctor
										</label>
									</div>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""gender_type"">
											<span class=""checkmark""></span> Female Doctor
										</label>
									</div>
								</div>
								<div class=""filter-widget"">
									<h4>Select Specialist</h4>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""select_specialist""");
            BeginWriteAttribute("checked", " checked=\"", 3543, "\"", 3553, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"checkmark\"></span> Urology\r\n\t\t\t\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t<label class=\"custom_check\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" name=\"select_specialist\"");
            BeginWriteAttribute("checked", " checked=\"", 3760, "\"", 3770, 0);
            EndWriteAttribute();
            WriteLiteral(@">
											<span class=""checkmark""></span> Neurology
										</label>
									</div>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""select_specialist"">
											<span class=""checkmark""></span> Dentist
										</label>
									</div>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""select_specialist"">
											<span class=""checkmark""></span> Orthopedic
										</label>
									</div>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""select_specialist"">
											<span class=""checkmark""></span> Cardiologist
										</label>
									</div>
									<div>
										<label class=""custom_check"">
											<input type=""checkbox"" name=""select_specialist"">
											<span class=""checkmark""></span> Cardiologist
										</label>
									</div>
								</div>
									<div class=""btn-search"">
										<button type=""button"" class=""btn");
            WriteLiteral(@" btn-block"">Search</button>
									</div>	
								</div>
							</div><div class=""resize-sensor"" style=""position: absolute; inset: 0px; overflow: hidden; z-index: -1; visibility: hidden;""><div class=""resize-sensor-expand"" style=""position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; z-index: -1; visibility: hidden;""><div style=""position: absolute; left: 0px; top: 0px; transition: all 0s ease 0s; width: 362px; height: 1815px;""></div></div><div class=""resize-sensor-shrink"" style=""position: absolute; left: 0; top: 0; right: 0; bottom: 0; overflow: hidden; z-index: -1; visibility: hidden;""><div style=""position: absolute; left: 0; top: 0; transition: 0s; width: 200%; height: 200%""></div></div></div></div></div>
						
						<div class=""col-md-12 col-lg-8 col-xl-9"">
");
#nullable restore
#line 117 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                             foreach( var item in Model)
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"card\">\r\n\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"doctor-widget\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"doc-info-left\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"doctor-img\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"doctor-profile.html\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 5877, "\"", 5943, 2);
            WriteAttributeValue("", 5883, "data:image;base64,", 5883, 18, true);
#nullable restore
#line 126 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
WriteAttributeValue("", 5901, Convert.ToBase64String(item.HotelPicture), 5901, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"User Image\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"doc-info-cont\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4 class=\"doc-name\">");
#nullable restore
#line 130 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                Write(item.HotelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"doc-speciality\">");
#nullable restore
#line 131 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                     Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h5 class=\"doc-department\">");
#nullable restore
#line 132 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                      Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"rating\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"class=\"fas fa-star filled\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"d-inline-block average-rating\">");
#nullable restore
#line 135 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                                           Write(item.NumOfStars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"clinic-details\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"doc-location\"><i class=\"fas fa-map-marker-alt\"></i>");
#nullable restore
#line 138 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                                                            Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<ul class=\"clinic-gallery\">\r\n");
#nullable restore
#line 140 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                         foreach ( var im in item.RoomImagesUrls)
													
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a class=\"avatar avatar-sm mr-2\" data-fancybox=\"gallery\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5b277a0b4bcac5033dfb0a05e21af3a923800cf421540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6799, "~/assets/img/rooms/", 6799, 19, true);
#nullable restore
#line 145 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
AddHtmlAttributeValue("", 6818, im.Url.Split("rooms\\").ElementAt(1), 6818, 37, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6855, ";", 6855, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 149 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"clinic-services\">\r\n");
#nullable restore
#line 155 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                     if(item.Suite==true)
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<span>Suit</span>\r\n");
#nullable restore
#line 158 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
										}
											else
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<span>Room</span>\r\n");
#nullable restore
#line 162 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
											}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"													
													
												</div>
											</div>
										</div>
										<div class=""doc-info-right"">
											<div class=""clini-infos"">
												<ul>
													<li><i class=""far fa-thumbs-up""></i> 98%</li>
													<li><i class=""far fa-comment""></i> 17 Feedback</li>
													<li><i class=""fas fa-bed""></i> ");
#nullable restore
#line 173 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                              Write(item.NumOfBeds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Beds</li>\r\n");
#nullable restore
#line 174 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                     if(item.Sea=="Yes")
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"fas fa-bed\"></i>With sea view</li>\r\n");
#nullable restore
#line 177 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
											}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"far fa-money-bill-alt\"></i> ");
#nullable restore
#line 179 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SY <i class=\"fas fa-info-circle\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 7864, "\"", 7872, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Lorem Ipsum\"></i> </li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"clinic-booking\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<a class=\"view-pro-btn\"");
            BeginWriteAttribute("href", "  href=\"", 8034, "\"", 8109, 1);
#nullable restore
#line 183 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
WriteAttributeValue("", 8042, Url.Action("EditRoom", "Room", new { RoomId = item.RoomEntityId }), 8042, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View Profile</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<a class=\"apt-btn\" data-room-id=\"");
#nullable restore
#line 184 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
                                                                            Write(item.RoomEntityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"  href=\"#\">Add This room forReservation</a>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 190 "C:\Users\ASUS\source\repos\Our-Hotels1 - test\Our-Hotels1\Views\Customer\SearchHotel.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t<!-- /Doctor Widget -->\r\n\t\t\t\t\t\t\t<div class=\"load-more text-center\">\r\n\t\t\t\t\t\t\t\t<a class=\"btn btn-primary btn-sm\" href=\"javascript:void(0);\">Load More</a>\t\r\n\t\t\t\t\t\t\t</div>\t\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b277a0b4bcac5033dfb0a05e21af3a923800cf428244", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

			<script>
    $(document).ready(function() {
        var selectedRoomIds = []; // List to store the selected room IDs

        // Handle the button click event
        $(document).on('click', '.apt-btn', function() {
            var roomId = $(this).data('room-id');

            // Check if the room ID is not already in the list before adding it
            if (!selectedRoomIds.includes(roomId)) {
                selectedRoomIds.push(roomId);
            }

            console.log(selectedRoomIds); // Display the list of selected room IDs in the console
			 return false; 
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OurHotels.Dto.Customer.RoomDetailsDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
