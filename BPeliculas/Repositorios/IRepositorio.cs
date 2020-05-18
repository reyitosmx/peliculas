using BPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPeliculas.Repositorios
{
    public interface IRepositorio
    {

        List<Pelicula> ObtenerPeliculas();
    }
}
