#pragma checksum "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96268751e6dd264a704d6e96ef470e10192d99e7"
// <auto-generated/>
#pragma warning disable 1591
namespace BPeliculas.Pages.Peliculas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/buscar")]
    public partial class FiltroPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Filtro Peliculas</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Titulo a Buscar : ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                      tituloa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-inline");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group mb-2");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<label for=\"tituloa\" class=\"sr-only\">Titulo</label>\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                              (KeyboardEventArgs e) => TituloKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "id", "tituloa");
            __builder.AddAttribute(17, "placeholder", "Titulo Pelicula");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                            tituloa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "oninuput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tituloa = __value, tituloa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                                generoSeleccionado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => generoSeleccionado = __value, generoSeleccionado));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "0");
            __builder.AddContent(32, "--Seleccione un genero---");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                 foreach (var item in generos)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                    ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", 
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                    item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, 
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                              item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "checkbox");
            __builder.AddAttribute(48, "class", "form-check-input");
            __builder.AddAttribute(49, "id", "estrenos");
            __builder.AddAttribute(50, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                                                                 futurosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurosEstrenos = __value, futurosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.AddMarkupContent(53, "<label class=\"form-check-label\" for=\"estrenos\">\r\n                Futuros Estrenos\r\n            </label>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "checkbox");
            __builder.AddAttribute(60, "class", "form-check-input");
            __builder.AddAttribute(61, "id", "cartelera");
            __builder.AddAttribute(62, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                                                                  enCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enCartelera = __value, enCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.AddMarkupContent(65, "<label class=\"form-check-label\" for=\"cartelera\">\r\n                En cartelera\r\n            </label>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "checkbox");
            __builder.AddAttribute(72, "class", "form-check-input");
            __builder.AddAttribute(73, "id", "masVotadas");
            __builder.AddAttribute(74, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                                                                   masVotadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => masVotadas = __value, masVotadas));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.AddMarkupContent(77, "<label class=\"form-check-label\" for=\"masVotadas\">\r\n                Mas Votadas\r\n            </label>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n        ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "type", "button");
            __builder.AddAttribute(81, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                                                             CargarNuevasPeliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Filtrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "type", "button");
            __builder.AddAttribute(87, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                                                    LimpiarOnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Limpiar");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n    ");
            __builder.OpenComponent<BPeliculas.Shared.ListadoPeliculas>(92);
            __builder.AddAttribute(93, "Peliculas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BPeliculas.Entidades.Pelicula>>(
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
                                 Peliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\BPeliculas\BPeliculas\Pages\Peliculas\FiltroPeliculas.razor"
           

        private List<Pelicula> Peliculas;
        string tituloa = "No hay titulo aun";
        string generoSeleccionado = "0";
        private bool futurosEstrenos = false;
        private bool enCartelera = false;
        private bool masVotadas = false;

        protected override void OnInitialized()
        {
            Peliculas = repositorio.ObtenerPeliculas();
        }

        private List<Genero> generos = new List<Genero>();

        private void TituloKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {

                CargarNuevasPeliculas();
            }

        }


        private void CargarNuevasPeliculas()
        {
            Peliculas = Peliculas.Where(x => x.Titulo.ToLower().Contains(tituloa.ToLower())).ToList();
            ///Peliculas = Peliculas.Where(x => x.Titulo.Contains(tituloa)).ToList();
        }

        private void LimpiarOnClick()
        {
            Peliculas = repositorio.ObtenerPeliculas();
            tituloa = "No hay titulo aun";
            generoSeleccionado = "0";
            futurosEstrenos = false;
            enCartelera = false;
            masVotadas = false;


        }



    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
