#pragma checksum "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715c60f06952fd748b7c61d943854a230f039b38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Association_VoirAssociation), @"mvc.1.0.view", @"/Views/Association/VoirAssociation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715c60f06952fd748b7c61d943854a230f039b38", @"/Views/Association/VoirAssociation.cshtml")]
    #nullable restore
    public class Views_Association_VoirAssociation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kili.ViewModels.CreerAssociationViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Détails Association";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>\r\n       Détails de l\'association\r\n    </h1>\r\n\r\n    <p>\r\n    \r\n    </p>\r\n\r\n        <Label>Nom de l\'association : ");
#nullable restore
#line 15 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
                                 Write(Model.association.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</Label><br /><br />\r\n        <Label>Adresse de l\'association : ");
#nullable restore
#line 16 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
                                     Write(Model.association.Adresse.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(", </Label><Label>");
#nullable restore
#line 16 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
                                                                                       Write(Model.association.Adresse.Voie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</Label><br />\r\n");
#nullable restore
#line 17 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
         if (@Model.association.Adresse.Complement != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <Label>                           ");
#nullable restore
#line 19 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
                                     Write(Model.association.Adresse.Complement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</Label><br />\r\n");
#nullable restore
#line 20 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <Label>");
#nullable restore
#line 21 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
          Write(Model.association.Adresse.CodePostal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
                                                Write(Model.association.Adresse.Ville);

#line default
#line hidden
#nullable disable
            WriteLiteral("</Label><br /><br /><br />\r\n        <Label>Thème : ");
#nullable restore
#line 22 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
                  Write(Model.association.Theme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</Label>\r\n        <br />\r\n        ");
#nullable restore
#line 24 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
   Write(Html.ActionLink("Modifier", "ModifierAssociation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\tolot\source\repos\KILI NEW GITHUB\Kili\Views\Association\VoirAssociation.cshtml"
   Write(Html.ActionLink("Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n}\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kili.ViewModels.CreerAssociationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
