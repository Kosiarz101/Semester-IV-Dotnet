#pragma checksum "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b86a9a43bdf0e1979f8121aaadfe1c7701a381f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FizzBuzzWebEdition.Pages.Pages_LastSearched), @"mvc.1.0.razor-page", @"/Pages/LastSearched.cshtml")]
namespace FizzBuzzWebEdition.Pages
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
#line 1 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\_ViewImports.cshtml"
using FizzBuzzWebEdition;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86a9a43bdf0e1979f8121aaadfe1c7701a381f9", @"/Pages/LastSearched.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c972908e0b5342d6ed333ee822e4f21eee52fa64", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LastSearched : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Dane zapisane z ostatniego wyszukania FizzBuzz</p>\r\n");
#nullable restore
#line 6 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
 if (Model.CurrentFizzBuzz != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 9 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
   Write(Html.DisplayNameFor(model => Model.CurrentFizzBuzz.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 10 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
   Write(Model.CurrentFizzBuzz.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 13 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
   Write(Html.DisplayNameFor(model => Model.CurrentFizzBuzz.SearchedValue));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 14 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
   Write(Model.CurrentFizzBuzz.SearchedValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 17 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
   Write(Html.DisplayNameFor(model => Model.CurrentFizzBuzz.LastSearchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        ");
#nullable restore
#line 18 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
   Write(Model.CurrentFizzBuzz.LastSearchDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        \r\n    </p>\r\n");
#nullable restore
#line 23 "F:\Users\Kosiarz\Documents\Projekty\C#\Semestr IV\FizzBuzzWebEdition\Pages\LastSearched.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FizzBuzzWebEdition.Pages.LastSearchedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FizzBuzzWebEdition.Pages.LastSearchedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FizzBuzzWebEdition.Pages.LastSearchedModel>)PageContext?.ViewData;
        public FizzBuzzWebEdition.Pages.LastSearchedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
