using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerApi.Api.Models
{
    public class Publicacion
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public int MeGusta { get; set; }

        public int MeDisgusta { get; set; }

        public int VecesCompartido { get; set; }

        public bool EsPrivada { get; set; }
    }
}