#pragma checksum "F:\HocKHTN\GitThuc\Git2\QLRapChieuPhim\QLRapChieuPhim\Pages\CapNhatPhim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e2651aa0c5eaaa8f71108f3dddb011f67e74eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QLRapChieuPhim.Pages.Pages_CapNhatPhim), @"mvc.1.0.razor-page", @"/Pages/CapNhatPhim.cshtml")]
namespace QLRapChieuPhim.Pages
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
#line 1 "F:\HocKHTN\GitThuc\Git2\QLRapChieuPhim\QLRapChieuPhim\Pages\_ViewImports.cshtml"
using QLRapChieuPhim;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e2651aa0c5eaaa8f71108f3dddb011f67e74eb", @"/Pages/CapNhatPhim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c02f2f3262353bd9ef2c31e47f1307b0ebef889", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CapNhatPhim : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45e2651aa0c5eaaa8f71108f3dddb011f67e74eb4532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .navbar ul.navbar-nav a.nav-link {
        font-size: 16px;
    }

    .form-group > label {
        margin-bottom: 0;
        margin-top: .5rem;
    }

    input, textarea {
        -webkit-appearance: auto;
    }

    .form-check {
        margin-bottom: .5rem;
    }

    .movie__info .img-thumbnail {
        width: 180px;
        height: 260px;
        cursor: pointer;
    }

    ");
            WriteLiteral("@media (min-width: 768px) {\r\n        .form-group > label {\r\n            text-align: right;\r\n        }\r\n\r\n        .movie__info .poster {\r\n            float: left;\r\n            width: 200px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 767px) {
        .movie__info .poster {
            width: 100%;
        }
    }
</style>
<!-- Main content -->
<section class=""container"">
    <div class=""col-md-12"">
        <div class=""movie"">
            <h2 class=""page-heading"">Cập nhật nội dung phim</h2>

            <div class=""movie__info"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e2651aa0c5eaaa8f71108f3dddb011f67e74eb6727", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group poster text-center\">\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 1244, "\"", 1252, 0);
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 1258, "\"", 1305, 2);
                WriteAttributeValue("", 1264, "data:image/png;base64,", 1264, 22, true);
#nullable restore
#line 56 "F:\HocKHTN\GitThuc\Git2\QLRapChieuPhim\QLRapChieuPhim\Pages\CapNhatPhim.cshtml"
WriteAttributeValue(" ", 1286, Model.Phim.Poster, 1287, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-thumbnail\" id=\"imgThumbnail\"></div>\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 1383, "\"", 1391, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""margin-top: 10px;"">
                            <input type=""button"" value=""Chọn hình"" class=""btn btn-info"" id=""chonHinh"" />
                            <input type=""file"" name=""inputFile"" id=""inputFile"" style=""display: none;"" />
                            <input type=""hidden"" name=""poster"" id=""poster""");
                BeginWriteAttribute("value", " value=\"", 1709, "\"", 1735, 1);
#nullable restore
#line 60 "F:\HocKHTN\GitThuc\Git2\QLRapChieuPhim\QLRapChieuPhim\Pages\CapNhatPhim.cshtml"
WriteAttributeValue("", 1717, Model.Phim.Poster, 1717, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group col-md-8"">
                        <label for=""tenphim"" class=""col-md-3"">Tên phim</label>
                        <div class=""col-md-9""><input type=""text"" name=""tenphim"" id=""tenphim"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2103, "\"", 2130, 1);
#nullable restore
#line 66 "F:\HocKHTN\GitThuc\Git2\QLRapChieuPhim\QLRapChieuPhim\Pages\CapNhatPhim.cshtml"
WriteAttributeValue("", 2111, Model.Phim.TenPhim, 2111, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group col-md-8"">
                        <label for=""tengoc"" class=""col-md-3"">Tên gốc</label>
                        <div class=""col-md-9""><input type=""text"" name=""tengoc"" id=""tengoc"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2469, "\"", 2477, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group col-md-8"">
                        <label for=""nuocsanxuat"" class=""col-md-3"">Nước sản xuất</label>
                        <div class=""col-md-9""><input type=""text"" name=""nuocsanxuat"" id=""nuocsanxuat"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2839, "\"", 2847, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group col-md-8"">
                        <label for=""nhasanxuat"" class=""col-md-3"">Nhà sản xuất</label>
                        <div class=""col-md-9""><input type=""text"" name=""nhasanxuat"" id=""nhasanxuat"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3205, "\"", 3213, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group col-md-8"">
                        <label for=""ngaykhoichieu"" class=""col-md-3"">Ngày khởi chiếu</label>
                        <div class=""col-md-3""><input type=""date"" name=""ngaykhoichieu"" id=""ngaykhoichieu"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3583, "\"", 3591, 0);
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                        <label for=\"thoiluong\" class=\"col-md-3\">Thời lượng (phút)</label>\r\n                        <div class=\"col-md-3\"><input type=\"number\" name=\"thoiluong\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3801, "\"", 3809, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group col-md-8"">
                        <label for=""trailer"" class=""col-md-3"">link trailer</label>
                        <div class=""col-md-9""><input type=""text"" name=""trailer"" id=""trailer"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 4155, "\"", 4163, 0);
                EndWriteAttribute();
                WriteLiteral(" /></div>\r\n                        <div class=\"clearfix\"></div>\r\n                    </div>\r\n                    <div class=\"clearfix\"></div>\r\n                    <div class=\"form-group\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 4383, "\"", 4389, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"col-md-2\">Thể loại</label>\r\n                        <div class=\"col-md-8\">\r\n");
                WriteLiteral(@"                                <div class=""col-md-4 col-sm-6 form-check"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"" name=""danhsachidtheloai""");
                BeginWriteAttribute("value", " value=\"", 4800, "\"", 4808, 0);
                EndWriteAttribute();
                WriteLiteral("> \r\n                                    </label>\r\n                                </div>\r\n");
                WriteLiteral(@"                        </div>
                        <div class=""clearfix""></div>
                    </div>

                    <div class=""form-group"">
                        <label for=""daodien"" class=""col-md-2"">Đạo diễn</label>
                        <div class=""col-md-8""><input type=""text"" name=""daodien"" id=""daodien"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 5287, "\"", 5295, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""dienvien"" class=""col-md-2"">Diễn viên</label>
                        <div class=""col-md-8""><input type=""text"" name=""dienvien"" id=""dienvien"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 5633, "\"", 5641, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""idxephangphim"" class=""col-md-2"">Xếp hạng phim</label>
                        <div class=""col-md-8"">
                            <select name=""idxephangphim"" id=""idxephangphim"" class=""form-control"">
                                
                            </select>
                        </div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""noidung"" class=""col-md-2"">Nội dung phim</label>
                        <div class=""col-md-8""><textarea name=""noidung"" id=""noidung"" rows=""5"" class=""form-control""></textarea></div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""form-group text-center"">
                        <button type=""submit"" class=""");
                WriteLiteral("btn btn-success\"><i class=\"fa fa-floppy-o\"></i> Lưu thông tin phim</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>\r\n");
            WriteLiteral("    <div id=\"dialog-message\" title=\"Thông báo\">\r\n        <div style=\"margin: 10px 0; font-weight: bold;\">\r\n            \r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"
<div class=""clearfix""></div>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#chonHinh, #imgThumbnail').click(function () {
            $('#inputFile').click();
        });

        $(""#dialog-message"").dialog({
            modal: true,
            buttons: {
                Ok: function () {
                    $(this).dialog(""close"");
                }
            }
        });
    });

    
    const inputFile = document.getElementById(""inputFile"");
    const imgPreview = document.getElementById(""imgThumbnail"");
    const post = document.getElementById(""poster"");
    inputFile.addEventListener(""change"", function () {
        const file = this.files[0];
        if (file) {
            const reader = new FileReader();
            reader.addEventListener(""load"", function () {
                imgPreview.setAttribute(""src"", this.result);
                var res = this.result.split("";base64,"");
                post.setAttribute(""value"", res[1]);
     ");
            WriteLiteral("       });\r\n            reader.readAsDataURL(file);\r\n        } else {\r\n            imgPreview.setAttribute(\"src\", \"images/movie/movie-sample-180x260.jpg\");\r\n            post.setAttribute(\"value\", \"\");\r\n        }\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLRapChieuPhim.Pages.CapNhatPhimModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QLRapChieuPhim.Pages.CapNhatPhimModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QLRapChieuPhim.Pages.CapNhatPhimModel>)PageContext?.ViewData;
        public QLRapChieuPhim.Pages.CapNhatPhimModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
