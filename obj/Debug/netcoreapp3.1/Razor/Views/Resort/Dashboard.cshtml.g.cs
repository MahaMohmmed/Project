#pragma checksum "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93de59ed8f35e4e73e7f5d2271cddd4e854c2b41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resort_Dashboard), @"mvc.1.0.view", @"/Views/Resort/Dashboard.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93de59ed8f35e4e73e7f5d2271cddd4e854c2b41", @"/Views/Resort/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Resort_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Resort>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewResort", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Resort", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bi bi-lightning-charge"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnReserve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReviewForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnFavoritee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b416322", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Dashboard</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b417503", async() => {
                WriteLiteral("\r\n     \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b417774", async() => {
                    WriteLiteral("<button\r\n        class=\"btn btn-sm btn-primary\">New Resort </button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        \r\n        <h1 style=\"font-family: fangsong;\r\n    color: slategray;\"> Your Resorts </h1>\r\n         <div class=\"cards\" >\r\n");
#nullable restore
#line 21 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
         foreach (var resort in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"card\" style=\" width: 20rem; height:20rem; margin-top:23px; margin-left:23px\">\r\n  <img style=\"height: 250px; margin-bottom: 15px\"");
                BeginWriteAttribute("src", " src=", 811, "", 830, 1);
#nullable restore
#line 24 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
WriteAttributeValue("", 816, resort.ImgUrl, 816, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> </img>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 854, "\"", 886, 2);
                WriteAttributeValue("", 861, "/resorts/", 861, 9, true);
#nullable restore
#line 25 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
WriteAttributeValue("", 870, resort.ResortId, 870, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <p  class=\"text-center\">");
#nullable restore
#line 26 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                   Write(resort.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            </a><p style=\"display: inline;\"  class=\"text-center\"> ");
#nullable restore
#line 27 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                             Write(resort.City.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n               <button class=\"btn btn-outline-danger\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b4111609", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-resortId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                        WriteLiteral(resort.ResortId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resortId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-resortId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resortId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <img src=\"https://img.icons8.com/material-outlined/24/fa314a/cancel--v1.png\"/>\r\n                </button>\r\n              \r\n                \r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n</div> \r\n<hr>\r\n\r\n        <h1 style=\"font-family: fangsong;\r\n    color: slategray;\"> Reservations </h1>\r\n         <div class=\"cards\" >\r\n");
#nullable restore
#line 45 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
         foreach (var item in ViewBag.MyReservations)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <div class=\"card\" style=\" width: 20rem; height:25rem; margin-top:23px; margin-left:23px\">\r\n        <img style=\"height: 250px; margin-bottom: 15px\"");
                BeginWriteAttribute("src", " src=", 1854, "", 1882, 1);
#nullable restore
#line 48 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
WriteAttributeValue("", 1859, item.ReservedIn.ImgUrl, 1859, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> </img>\r\n         <a");
                BeginWriteAttribute("href", " href=\"", 1903, "\"", 1944, 2);
                WriteAttributeValue("", 1910, "/resorts/", 1910, 9, true);
#nullable restore
#line 49 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
WriteAttributeValue("", 1919, item.ReservedIn.ResortId, 1919, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n             <p class=\"text-center\">");
#nullable restore
#line 50 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                               Write(item.ReservedIn.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></a>\r\n            <p class=\"text-center\">");
#nullable restore
#line 51 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                              Write(item.ReservedIn.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" at ");
#nullable restore
#line 51 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                       Write(item.ReservedIn.City.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n            <p class=\"text-center\">");
#nullable restore
#line 52 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                              Write(item.FromDate.ToString("dd MMM yyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" to ");
#nullable restore
#line 52 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                                       Write(item.ToDate.ToString("dd MMM yyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
             if(item.FromDate > DateTime.Now){ 

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-outline-danger\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b4117967", async() => {
                    WriteLiteral("Cancel Reservation");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-resortId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                                                                                 WriteLiteral(item.ResortId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resortId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-resortId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resortId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                                                                                                                     WriteLiteral(item.ReservationId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reservId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reservId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <img src=\"https://img.icons8.com/material-outlined/24/fa314a/cancel--v1.png\"/>\r\n                </button>\r\n");
#nullable restore
#line 58 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
            }
            else
            { 
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-outline-success\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b4121952", async() => {
                    WriteLiteral("  Leave A Comment ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-resorttId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                                                                                    WriteLiteral(item.ResortId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resorttId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-resorttId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resorttId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                                                                                                                      WriteLiteral(ViewBag.User.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <img src=\"https://img.icons8.com/windows/32/26e07f/comment-medical.png\"/>\r\n                </button> \r\n");
#nullable restore
#line 65 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("             </div>\r\n");
#nullable restore
#line 67 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("         </div>\r\n         <hr>\r\n       \r\n        <h1 style=\"font-family: fangsong;\r\n    color: slategray;\">Favorite Resort</h1>\r\n       <div class=\"cards\" > \r\n");
#nullable restore
#line 75 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
             foreach (var fav in ViewBag.favRes)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("   <div class=\"card\" style=\" width: 20rem; height:20rem; margin-top:23px; margin-left:23px\">\r\n                <img style=\"height: 250px; margin-bottom: 15px\"");
                BeginWriteAttribute("src", " src=", 3516, "", 3539, 1);
#nullable restore
#line 77 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
WriteAttributeValue("", 3521, fav.FavRes.ImgUrl, 3521, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> </img>\r\n               <a");
                BeginWriteAttribute("href", " href=\"", 3566, "\"", 3602, 2);
                WriteAttributeValue("", 3573, "/resorts/", 3573, 9, true);
#nullable restore
#line 78 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
WriteAttributeValue("", 3582, fav.FavRes.ResortId, 3582, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <p  class=\"text-center\">");
#nullable restore
#line 79 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                 Write(fav.FavRes.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></a>\r\n                <p class=\"text-center\" >");
#nullable restore
#line 80 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                   Write(fav.FavRes.City.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <button class=\"btn btn-outline-danger\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93de59ed8f35e4e73e7f5d2271cddd4e854c2b4128175", async() => {
                    WriteLiteral("UnFavorite");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-resortId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
                                                                                                                       WriteLiteral(fav.ResortId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resortId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-resortId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resortId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-heart"" viewBox=""0 0 16 16"">
                            <path d=""m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z""/>
                          </svg>
                          </button>
            </div>
");
#nullable restore
#line 88 "C:\Users\USER\Desktop\coding_dojo\Project (3)\Project\Views\Resort\Dashboard.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n      \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Resort>> Html { get; private set; }
    }
}
#pragma warning restore 1591