#pragma checksum "/Users/jeverett/Desktop/joshuaeverett22/jeverett/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403448233e3a5a1c4205b2d8a87d4cb6e7a69ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "/Users/jeverett/Desktop/joshuaeverett22/jeverett/Views/_ViewImports.cshtml"
using jeverett;

#line default
#line hidden
#line 2 "/Users/jeverett/Desktop/joshuaeverett22/jeverett/Views/_ViewImports.cshtml"
using jeverett.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403448233e3a5a1c4205b2d8a87d4cb6e7a69ab6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef12f203067ea784408a8ea10bf4b6f4ce85600", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403448233e3a5a1c4205b2d8a87d4cb6e7a69ab63737", async() => {
                BeginContext(31, 184, true);
                WriteLiteral("\r\n  <meta charset=\"utf-8\" />\r\n  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"/>\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>\r\n  <title>");
                EndContext();
                BeginContext(216, 17, false);
#line 7 "/Users/jeverett/Desktop/joshuaeverett22/jeverett/Views/Shared/_Layout.cshtml"
    Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(233, 1616, true);
                WriteLiteral(@" | Joshua Everett</title>
  <link rel=""shortcut icon"" type=""image/png"" href=""/iassets/je-icon.png"" />

  <!-- MATERIAL CSS  -->
  <link href=""/css/site.css"" type=""text/css"" rel=""stylesheet"" media=""screen,projection""/>
  <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
  <link href=""/css/materialize.css"" type=""text/css"" rel=""stylesheet"" media=""screen,projection""/>
  
  <link href=""/css/style.css"" type=""text/css"" rel=""stylesheet"" media=""screen,projection""/>

   <link href=""https://fonts.googleapis.com/css?family=Audiowide|Cinzel|Economica:700|Liu+Jian+Mao+Cao|Rock+Salt&display=swap"" rel=""stylesheet""> 

<meta name=""description"" content=""Computer Software Engineering graduate with intensive training in software development. Well-versed in Python, C#/.Net, JavaScript, MongoDB, Django and MySQL. Military veteran with strong ability to manage projects from concept to completion ensuring on-time, on-budget, and on-target results. Equally adept at working with teams an");
                WriteLiteral(@"d individually with minimal supervision.  "" />
<meta name=""keywords"" content=""AI, artifical Intelligence, software engineering, software, developer, full-stack, fullstack, python, ajax, java, mean, C#, maryland, lexington park, PAX, 919-588-0090"" />
<!-- Global site tag (gtag.js) - Google Analytics -->
<!-- <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-150260289-2""></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'UA-150260289-2');
</script>
 -->


");
                EndContext();
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
            EndContext();
            BeginContext(1856, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1858, 2881, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403448233e3a5a1c4205b2d8a87d4cb6e7a69ab67132", async() => {
                BeginContext(1864, 703, true);
                WriteLiteral(@"
    
<div id=""menu"">
    <!--MATERIAL NAV-->
  <nav class=""navbar-fixed"" >
    <div class=""nav-wrapper #455a64 #263238 blue-grey darken-4"">
    <img src=""/iassets/eagle2.png"" alt=""Joshua Everett"" style=""margin-left: 8px; width:70px; margin-top:11px;"">
      <span class=""nav-name"">Joshua Everett</span>
      <ul class=""right hide-on-med-and-down"">
      <li><a class=""white-text"" href=""#resume"">resume</a></li>
      <li><a class=""white-text"" href=""#projects"">projects</a></li>
      <li><a class=""white-text"" href=""#contact"">contact</a></li>
    </ul>

  </nav>

</div>
  <!--END MATERIAL NAV-->
  
      <div class=""container"">
      <main role=""main"" class=""pb-3"">
            ");
                EndContext();
                BeginContext(2568, 12, false);
#line 55 "/Users/jeverett/Desktop/joshuaeverett22/jeverett/Views/Shared/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2580, 1715, true);
                WriteLiteral(@"
      </main>
    </div>

    

    <!--MATERIAL FOOTER-->
<footer class=""page-footer light-green  black-text"">
    <div class=""container"">
      <div class=""row"">
        
        <!--COL 1--> 
        <div class=""card-panel grey lighten-5 z-depth-1 col s6"">
          <div class=""row valign-wrapper"">
            <div class=""col s2"">
              <img src=""iassets/me.jpeg"" alt="""" class=""circle responsive-img"" alt=""Joshua Everett""> <!-- notice the ""circle"" class -->
            </div>
            <div class=""col s10"">

              <ul class=""collection"">
                <li class=""collection-item""><i class=""material-icons"">phone</i>  (240) 233-4112‬</li>
                <li class=""collection-item""><i class=""material-icons"">send</i>  joshuaeverett22@gmail.com</li>
              </ul>

            </div>  
      </div></div>

             <!--COL 2--> 
        <div class=""card-panel grey lighten-5 z-depth-1 col s6"">
          <div class=""row valign-wrapper"">

            <div c");
                WriteLiteral(@"lass=""col s12"">
              <ul class=""collection"">
                <li class=""collection-item foot-ico""><img src=""/iassets/icons/linkedin.png"" alt=""LinkedIn""><a href=""https://www.linkedin.com/in/joshuaeverett22/"">  view my linkedin profile‬</a></li>

                <li class=""collection-item foot-ico""><img src=""/iassets/icons/github.png"" alt=""Github""><a href=""https://github.com/everett-j"">  view my github‬</a></li>


              </ul>
            </div>
          
      
        
        
      </div>
    </div>
    </div>
    <div class="" cinzel-font"">
     
      © Joshua Everett
      
    </div>
  </footer>

    <!--END MATERIAL FOOTER-->

  
    ");
                EndContext();
                BeginContext(4295, 385, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403448233e3a5a1c4205b2d8a87d4cb6e7a69ab610391", async() => {
                    BeginContext(4330, 336, true);
                    WriteLiteral(@"
        
          <!-- MATERIAL JavaScript -->
<!--  Scripts-->
  <script src=""https://code.jquery.com/jquery-2.1.1.min.js""></script>
  <script src=""/js/materialize.js""></script>
  <script src=""/js/materialize.min.js""></script>
  <script src=""/js/init.js""></script>
           <!-- Compiled and minified JavaScript -->

    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4680, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4689, 41, false);
#line 124 "/Users/jeverett/Desktop/joshuaeverett22/jeverett/Views/Shared/_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4730, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(4739, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
