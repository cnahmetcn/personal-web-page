#pragma checksum "C:\Users\daSilva\Desktop\AspNetCore\Website\Website\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f39c8f7d118b7f2e3013d8824b19e38510a3d379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f39c8f7d118b7f2e3013d8824b19e38510a3d379", @"/Views/Home/Contact.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\daSilva\Desktop\AspNetCore\Website\Website\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "İletişim";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""global-page-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""block"">
                    <h2>İletişim</h2>
                    <ol class=""breadcrumb"">
                        <li>
                            <a href=""Index"">
                                <i class=""ion-ios-home""></i>
                                Anasayfa
                            </a>
                        </li>
                        <li class=""active"">İletişim</li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
</section>


<section id=""contact-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""block"">
                    <h2 class=""subtitle wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay="".3s"">Mesaj Gönder</h2>

                    <div id=""back"">
");
#nullable restore
#line 35 "C:\Users\daSilva\Desktop\AspNetCore\Website\Website\Views\Home\Contact.cshtml"
                         if (ViewBag.Success != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-success\">\r\n                                Teşekkür ederim. Postacı Yolda :)\r\n                            </p>\r\n");
#nullable restore
#line 40 "C:\Users\daSilva\Desktop\AspNetCore\Website\Website\Views\Home\Contact.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\daSilva\Desktop\AspNetCore\Website\Website\Views\Home\Contact.cshtml"
                         if (ViewBag.Error != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-danger\">\r\n                                Üzgünüm, ne olduğunu bilmiyorum. Daha sonra tekrar deneyin :(\r\n                            </p>\r\n");
#nullable restore
#line 46 "C:\Users\daSilva\Desktop\AspNetCore\Website\Website\Views\Home\Contact.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                    <div class=""contact-form"">
                        <form method=""post"" action=""/Home/Contact"">

                            <div class=""form-group wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay="".6s"">
                                <input type=""text"" placeholder=""Adınız"" class=""form-control"" name=""Name"" id=""Name"" required>
                            </div>

                            <div class=""form-group wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay="".8s"">
                                <input type=""text"" placeholder=""Soyadınız"" class=""form-control"" name=""Surname"" id=""surname"" required>
                            </div>

                            <div class=""form-group wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay=""1s"">
                                <input type=""email"" placeholder=""Mail Adresiniz"" class=""form-control"" name=""Email"" id=""Email"" required>
                            </div>

                ");
            WriteLiteral(@"            <div class=""form-group wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay=""1.2s"">
                                <input type=""text"" placeholder=""Konu"" class=""form-control"" name=""Subject"" id=""Subject"" required>
                            </div>

                            <div class=""form-group wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay=""1.4s"">
                                <textarea rows=""6"" placeholder=""Mesaj"" class=""form-control"" name=""Message"" id=""Message"" required></textarea>
                            </div>

                            <div id=""submit"" class=""wow fadeInDown"" data-wow-duration=""500ms"" data-wow-delay=""1.4s"">
                                <input type=""submit"" id=""contact-submit"" class=""btn btn-default btn-send"" value=""Gönder"">
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""map-area"">
");
            WriteLiteral(@"                    <div class=""map"">
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d199215.8970671012!2d35.3301017516478!3d38.723585291072546!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x152b0e1d3fa4a74f%3A0x84bd8c4d5a4c2da7!2sKayseri!5e0!3m2!1str!2str!4v1611660174472!5m2!1str!2str"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4034, "\"", 4052, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>

                    </div>
                </div>
            </div>
        </div>
        <div class=""row address-details"">
            <div class=""col-md-4"">
                <div class=""address wow fadeInLeft"" data-wow-duration=""500ms"" data-wow-delay="".5s"">
                    <i class=""ion-ios-location-outline""></i>
                    <h5>Kayseri, Türkiye</h5>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""email wow fadeInLeft"" data-wow-duration=""500ms"" data-wow-delay="".7s"">
                    <i class=""ion-ios-email-outline""></i>
                    <p><a href=""mailto:cnahmet@outlook.com"">cnahmet@outlook.com</a> <br /> </p>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""phone wow fadeInLeft"" data-wow-duration=""500ms"" data-wow-delay="".9s"">
                    <i class=""ion-ios-telephone-outline""></i>
                    <p>");
            WriteLiteral("+90 5xx xxx xx xx <br /></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
