using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApi.Api.Models
{
    public class TallerContext : DbContext
    {
        public TallerContext() : base("TallerApiConnection")
        {

        }

        public DbSet<Publicacion> Publicacion { get; set; }
    }
}

