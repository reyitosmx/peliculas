#pragma checksum "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee1d08bfb176b4f044ddd701f2ee3b9b894bbbe"
// <auto-generated/>
#pragma warning disable 1591
namespace BPeliculas.Pages.Personas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using BPeliculas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using BPeliculas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using BPeliculas.Utilerias;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using BPeliculas.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\_Imports.razor"
using BPeliculas.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class FormularioPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                 Persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                                           OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Nombre:</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                                                          Persona.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Persona.Nombre = __value, Persona.Nombre))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Persona.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.BPeliculas.Pages.Personas.FormularioPersonas.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                                      () => Persona.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label>Fecha Nacimiento:</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.BPeliculas.Pages.Personas.FormularioPersonas.TypeInference.CreateInputDate_1(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 15 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                                                          Persona.FechaNacimiento

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Persona.FechaNacimiento = __value, Persona.FechaNacimiento)), 34, () => Persona.FechaNacimiento);
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.BPeliculas.Pages.Personas.FormularioPersonas.TypeInference.CreateValidationMessage_2(__builder2, 36, 37, 
#nullable restore
#line 16 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                                      () => Persona.FechaNacimiento

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n\r\n        ");
                __builder2.OpenComponent<BPeliculas.Shared.InputImg>(44);
                __builder2.AddAttribute(45, "Label", "Foto");
                __builder2.AddAttribute(46, "ImagenSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
                                                   ImagenSeleccionada

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "ImagenTemporal", "");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n     \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n    ");
                __builder2.AddMarkupContent(50, "<div class=\"form-group\">\r\n       \r\n    </div>\r\n\r\n    ");
                __builder2.AddMarkupContent(51, "<button class=\"btn btn-success\" type=\"submit\">Guardar Cambios</button>\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Personas\FormularioPersonas.razor"
       

    [Parameter] public Persona Persona { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    private string imagenTemporal;

    protected override void OnInitialized()
    {
        if (!string.IsNullOrWhiteSpace(Persona.Foto))
        {
            imagenTemporal = Persona.Foto;
            Persona.Foto = null;
        }

    }

    private void ImagenSeleccionada(string imagenBase64)
    {
        Persona.Foto = imagenBase64;


    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BPeliculas.Pages.Personas.FormularioPersonas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
