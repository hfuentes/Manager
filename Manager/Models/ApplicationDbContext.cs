using Manager.Negocio;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Manager.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base(Constantes.BD_CONNECTION_NAME) { }

        public DbSet<Tienda> Tiendas { get; set; }
    }
}