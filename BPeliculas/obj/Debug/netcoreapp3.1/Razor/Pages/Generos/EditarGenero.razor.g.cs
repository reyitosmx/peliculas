#pragma checksum "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Generos\EditarGenero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b50181297bd88cddc4fe82e9f009eb2718790435"
// <auto-generated/>
#pragma warning disable 1591
namespace BPeliculas.Pages.Generos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/generos/editar/{GeneroId:int}")]
    public partial class EditarGenero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Genero</h3>\r\n");
            __builder.OpenComponent<BPeliculas.Pages.Generos.FormularioGenero>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Generos\EditarGenero.razor"
                                 Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Genero", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BPeliculas.Entidades.Genero>(
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Generos\EditarGenero.razor"
                                                 Genero

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Generos\EditarGenero.razor"
       

    [Parameter] public int GeneroId { get; set; }
    private Genero Genero;

    protected override void OnInitialized()
    {
        Genero = new Genero() { Id = GeneroId, Nombre = "Comedia" };
    }

    private async Task Editar()
    {
        await js.Confirm("Ejecutando Metodo Editar Genero");
        await js.Confirm($"Id = {Genero.Id}");
        await js.Confirm($"Genero : {Genero.Nombre}");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
