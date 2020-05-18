using BPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BPeliculas.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula() { Titulo = "Spider-man : far from home ", Lanzamiento = new DateTime(1966, 07, 19),
                  Poster="spider-man.jpg"},
                new Pelicula() { Titulo = "Mi Villano Favorito", Lanzamiento = new DateTime(1975, 12, 25),
                  Poster="mivillano2.jpg"},
                new Pelicula() { Titulo = "Harry Potter", Lanzamiento = new DateTime(2001, 03, 02),
                  Poster="harrypotter.jpg"}

            };
        }
    }
}
