#pragma checksum "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0571a6e02fce33d98cb261203b67d5cb6c03bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ASM_Cart), @"mvc.1.0.view", @"/Views/ASM/Cart.cshtml")]
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
#line 1 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\_ViewImports.cshtml"
using ASM1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\_ViewImports.cshtml"
using ASM1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0571a6e02fce33d98cb261203b67d5cb6c03bc", @"/Views/ASM/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e75a035d0b826e75652e7ff042dd4c34eb38237", @"/Views/_ViewImports.cshtml")]
    public class Views_ASM_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ASM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
  
        ViewData["Title"] = "Cart";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc5814", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Giỏ Hàng</title>
    <link rel=""stylesheet"" href=""/css/cart.css"">
    <link rel=""stylesheet"" href=""/css/Style.css"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc7090", async() => {
                WriteLiteral("\r\n    <section id=\"header\">\r\n            <div class=\"header container\">\r\n                <div class=\"nav-bar\">\r\n                    <div class=\"brand\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc7539", async() => {
                    WriteLiteral("\r\n                            <h1><span>H</span>ien <span>S</span>tore</h1>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""nav-list"">
                        <div class=""hamburger"">
                            <div class=""bar""></div>
                        </div>
                        <ul>

                            <li class=""sp"">
                                <a href=""#San-Pham"" data-after=""SanPham"">Sản Phẩm</a>
                                <div class=""sub-menu1"">
                                    <ul>
                                        <li>
                                            <a href=""#Nam"">
                                                <img src=""/images/main/chonam.jpg"">
                                                <h3>Cho Nam</h3>
                                            </a>
                                        </li>

                                        <li>
                                            <a href=""#Nu"">
                                                <img src=""/images/main/chonu.jpeg"">
     ");
                WriteLiteral(@"                                           <h3>Cho Nữ</h3>
                                            </a>
                                        </li>
                                    </ul>
                                </div>

                            </li>
                            <li><a href=""#Nam"" data-after=""Nam"">Nam</a></li>
                            <li><a href=""#Nu"" data-after=""Nu"">Nữ</a></li>
                            <li><a href=""#Thong-Tin"" data-after=""ThongTin"">Thông Tin</a></li>
                            <li>
                                <a>
                                    <div class=""search-box"">
                                        <div class=""input-box"">
                                            <input type=""text"" placeholder=""Tìm Kiếm Sản Phẩm"">
                                        </div>
                                        <button class=""search-button"">
                                            <img src=""/images/main/search.png""");
                BeginWriteAttribute("alt", " alt=\"", 2771, "\"", 2777, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </button>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a href=""ASM/Cart"">
                                    <div class=""gio-hang"">
                                        <button class=""button-giohang"">
                                            <img src=""/images/main/giohang.png"">
                                        </button>
                                    </div>
                                </a>
                            </li>
                            <li>
");
#nullable restore
#line 77 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                                   if (ViewBag.UsersName != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc12397", async() => {
                    WriteLiteral(@"
                                            <div class=""acount"">

                                                <button class=""button-acount"">
                                                    <img src=""/images/main/account.png"">
                                                </button>

                                            </div>
                                            <h3>");
#nullable restore
#line 87 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                                           Write(ViewBag.UsersName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h3>\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <div class=\"sub-menu1\">\r\n                                            <ul>\r\n\r\n                                                <li>\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc14814", async() => {
                    WriteLiteral("\r\n                                                        <h3>Quản Lý Users</h3>\r\n                                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc16432", async() => {
                    WriteLiteral("\r\n                                                        <h3>Quản Lý Sản Phẩm</h3>\r\n                                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    <a");
                BeginWriteAttribute("onclick", " onclick=\"", 4820, "\"", 4876, 5);
                WriteAttributeValue("", 4830, "location.href", 4830, 13, true);
                WriteAttributeValue(" ", 4843, "=", 4844, 2, true);
                WriteAttributeValue(" ", 4845, "\'", 4846, 2, true);
#nullable restore
#line 99 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
WriteAttributeValue("", 4847, Url.Action("Logout", "ASM"), 4847, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4875, "\'", 4875, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                                        <h3>Log Out</h3>
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
");
#nullable restore
#line 105 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc19460", async() => {
                    WriteLiteral(@"
                                          <div class=""acount"">

                                          <button class=""button-acount"">
                                           <img src=""/images/main/account.png"">
                                          </button>

                                         </div>
                                          ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 117 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </section>
    <div class=""container"">
        <div class=""payment_details"">
            <h1>THÔNG TIN GIAO HÀNG</h1>
            <div class=""details_card"">
                <div class=""name_address"">
                    <div class=""first_lastName"">
                        <input type=""text"" placeholder=""Họ & Tên"" required />
                        <input type=""text"" placeholder=""SĐT"" required />
                    </div>
                    <div class=""address"">
                        <input type=""text"" placeholder=""Email"" required />
                        <input type=""text"" onkeyup=""change()"" id=""put"" placeholder=""Địa Chỉ"" required />
                    </div>
                </div>
                <h1>Ghi Chú</h1>
                <div class=""ghichu"">
                    <input type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6812, "\"", 6826, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"order_summary\">\r\n            <h1>Đơn Hàng</h1>\r\n            <div class=\"summary_card\">\r\n");
#nullable restore
#line 150 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                 foreach (var item in ViewBag.cart)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"card_item\">\r\n                        <div class=\"product_img\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 7202, "\"", 7235, 1);
#nullable restore
#line 154 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
WriteAttributeValue("", 7208, item.Products.ProductImage, 7208, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"product_info\">\r\n                            \r\n                            <h1>");
#nullable restore
#line 158 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                           Write(item.Products.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                            <div class=\"close-btn\">\r\n                                <i class=\"fa fa-close\"></i>\r\n                            </div>\r\n                            <div class=\"product_rate_info\">\r\n                                <h1>");
#nullable restore
#line 163 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                               Write(item.Products.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b0571a6e02fce33d98cb261203b67d5cb6c03bc24846", async() => {
                    WriteLiteral("\r\n                                    <span class=\"pqt-minus\" >-</span>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 164 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                                                                              WriteLiteral(item.Products.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                
                                <span class=""pqt"">1</span>
                                <span class=""pqt-plus"">+</span>
                            </div>
                        </div>
                    </div>
                    <hr />
                    <div class=""order_donhang"">
                        <p>Đơn Hàng</p>
                        <h4>");
#nullable restore
#line 176 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                       Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    </div>\r\n");
#nullable restore
#line 178 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""order_ship"">
                        <p>Phí Vận Chuyển</p>
                        <h4>30.000 VNĐ</h4>
                    </div>
                    <div class=""order_tong"">
                        <p>Tổng Cộng</p>
                        <h4>");
#nullable restore
#line 185 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
                       Write(ViewBag.total1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"ThanhToan\">\r\n                        <a");
                BeginWriteAttribute("onclick", " onclick=\"", 8800, "\"", 8864, 5);
                WriteAttributeValue("", 8810, "location.href", 8810, 13, true);
                WriteAttributeValue(" ", 8823, "=", 8824, 2, true);
                WriteAttributeValue(" ", 8825, "\'", 8826, 2, true);
#nullable restore
#line 188 "C:\Users\Tan Hien\OneDrive\Documents\Kỳ_5\C#4\Bài Lab\PS16180_LeTanHien_ASM2\ASM1\ASM1\Views\ASM\Cart.cshtml"
WriteAttributeValue("", 8827, Url.Action("Create", "CartDetails"), 8827, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8863, "\'", 8863, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"submit\" value=\"Hoàn Tất Đặt Hàng\">\r\n                        </a>\r\n                        \r\n                    </div>\r\n                </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
