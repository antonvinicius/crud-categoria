using CrudCategoria.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCategoria.Server.Data
{
    public class DbContextApp : DbContext
    {
        public DbContextApp(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
