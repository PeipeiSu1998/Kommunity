#pragma checksum "C:\Users\Diego H\source\repos\Kommunity_WebApp\Kommunity_WebApp\Pages\Admin\settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "737b97c3f033e848417933276090792d0aad9aad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kommunity_WebApp.Pages.Admin.Pages_Admin_settings), @"mvc.1.0.razor-page", @"/Pages/Admin/settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/settings.cshtml", typeof(Kommunity_WebApp.Pages.Admin.Pages_Admin_settings), null)]
namespace Kommunity_WebApp.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Diego H\source\repos\Kommunity_WebApp\Kommunity_WebApp\Pages\_ViewImports.cshtml"
using Kommunity_WebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737b97c3f033e848417933276090792d0aad9aad", @"/Pages/Admin/settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b254aff7ccfe927781fdef2444f7a13f7718cf1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_settings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Diego H\source\repos\Kommunity_WebApp\Kommunity_WebApp\Pages\Admin\settings.cshtml"
  
    ViewData["Title"] = "settings";

#line default
#line hidden
#line 5 "C:\Users\Diego H\source\repos\Kommunity_WebApp\Kommunity_WebApp\Pages\Admin\settings.cshtml"
   
    Layout = "_Admin";

#line default
#line hidden
            BeginContext(131, 939, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <!-- Blog Entries Column -->
        <div class=""col-md-12"">
            <br /> <br />
            <!-- Blog Post -->
            <div class=""card mb-4"">
                <div class=""card-body"">
                    <h2 class=""card-title"">Settings</h2>

                    <h3>Change user's role</h3>
                    <div class=""modal-body form-horizontal"">
                        <div class=""control-group"">
                            <label>Write user's CPR</label>
                            <div class=""controls"">
                                <input type=""text"">
                            </div>
                        </div>
                        <div class=""control-group"" style=""width: 180px"">
                            <label>Select new role</label>
                            <select class=""form-control"">
                                ");
            EndContext();
            BeginContext(1070, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bdd498040249ee9fdcdb69f87fc87a", async() => {
                BeginContext(1078, 5, true);
                WriteLiteral("Admin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1092, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1126, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a466b001d6249de856114b657c99e63", async() => {
                BeginContext(1134, 4, true);
                WriteLiteral("User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1147, 2608, true);
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    <h3>Change your password</h3>
                    <div class=""modal-body form-horizontal"">
                        <div class=""control-group"">
                            <label for=""current_password"" class=""control-label"">Current Password</label>
                            <div class=""controls"">
                                <input type=""password"" name=""current_password"">
                            </div>
                        </div>
                        <div class=""control-group"">
                            <label for=""new_password"" class=""control-label"">New Password</label>
                            <div class=""controls"">
                                <input type=""password"" name=""new_password"">
                            </div>
                        </div>
                   ");
            WriteLiteral(@"     <div class=""control-group"">
                            <label for=""confirm_password"" class=""control-label"">Confirm Password</label>
                            <div class=""controls"">
                                <input type=""password"" name=""confirm_password"">
                            </div>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    <br>
                    <h3>Change your email</h3>
                    <div class=""modal-body form-horizontal"">
                        <div class=""control-group"">
                            <label>New Email</label>
                            <div class=""controls"">
                                <input type=""text"">
                            </div>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    <br>
                   ");
            WriteLiteral(@" <h3>Change your city</h3>
                    <div class=""modal-body form-horizontal"">
                        <div class=""control-group"">
                            <label>New City</label>
                            <div class=""controls"">
                                <input type=""text"">
                            </div>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>

                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kommunity_WebApp.Pages.Admin.settingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Kommunity_WebApp.Pages.Admin.settingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Kommunity_WebApp.Pages.Admin.settingsModel>)PageContext?.ViewData;
        public Kommunity_WebApp.Pages.Admin.settingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591