#pragma checksum "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\PeliculaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "299723ccbeb522b5d6563a2548e1a0a25e410a80"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BPeliculas.Shared
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
    public partial class PeliculaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\PeliculaIndividual.razor"
      

    [Parameter] public Pelicula Pelicula { get; set; }
    [Parameter] public bool MostrarBotones { get; set; } = false;
    [Parameter] public EventCallback<Pelicula> EliminarPelicula { get; set; }

    private string urlPelicula = string.Empty;

    protected override void OnInitialized()
    {
        urlPelicula = $"pelicula/";
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
