#pragma checksum "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\ListadoPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2d5a4738b3dfad7ac80e653109129c349296f0"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ListadoPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display: flex; flex-wrap: wrap; align-items: center;");
            __builder.AddMarkupContent(2, "\r\n\r\n ");
            __Blazor.BPeliculas.Shared.ListadoPeliculas.TypeInference.CreateListadoGenerico_0(__builder, 3, 4, 
#nullable restore
#line 5 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\ListadoPeliculas.razor"
                           Peliculas

#line default
#line hidden
#nullable disable
            , 5, (pelicula) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n\r\n            ");
                __builder2.OpenComponent<BPeliculas.Shared.PeliculaIndividual>(7);
                __builder2.AddAttribute(8, "Pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BPeliculas.Entidades.Pelicula>(
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\ListadoPeliculas.razor"
                                          pelicula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "EliminarPelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BPeliculas.Entidades.Pelicula>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BPeliculas.Entidades.Pelicula>(this, 
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\ListadoPeliculas.razor"
                                                                      EliminarPelicula

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n        ");
            }
            );
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Shared\ListadoPeliculas.razor"
       



    /// <summary>
    /// ahora vamos a declarar el listado de peliculas como parametro
    /// para eso requerimos declarar la variable Peliculas como public
    /// y agregarle la palabra parameter al principio y ademas deber tener las propiedas
    /// get y set para que funciones como parametro
    /// </summary>
    /// <returns></returns>
    ///

    [Parameter] public List<Pelicula> Peliculas { get; set; }
   


    async Task EliminarPelicula(Pelicula pelicula)
    {
        var confirmar = await js.Confirm($"Desea eliminar la pelicula {pelicula.Titulo}?");
        if (confirmar)
        {
            Peliculas.Remove(pelicula);
        }
    }


    //estes es un ciclo de vida de un coompenente
    //este se carga al inicar la carga de la pagina  donde este localidado
    /// <summary>
    /// este ciclo de vida por el momento s¿lo vamos a deshabilitar
    /// ya que no lo vamos a ocupar
    /// </summary>
    /// <returns></returns>
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.BPeliculas.Shared.ListadoPeliculas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::BPeliculas.Shared.ListadoGenerico<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
