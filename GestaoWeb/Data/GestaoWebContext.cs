using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoWeb.Models;

namespace GestaoWeb.Data
{
    public class GestaoWebContext : DbContext
    {
        public GestaoWebContext (DbContextOptions<GestaoWebContext> options)
            : base(options)
        {
        }

        public DbSet<GestaoWeb.Models.Sala> Sala { get; set; } = default!;

        public DbSet<GestaoWeb.Models.Cliente> Clientes { get; set; } = default!;
    }
}
