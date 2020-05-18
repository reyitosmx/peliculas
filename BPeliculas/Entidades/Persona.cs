﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BPeliculas.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public string Foto { get; set; }
        [Required]
        public DateTime? FechaNacimiento { get; set; }


    }
}
