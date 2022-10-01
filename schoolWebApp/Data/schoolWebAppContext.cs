using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using schoolWebApp.Models;

namespace schoolWebApp.Data
{
    public class schoolWebAppContext : DbContext
    {
        public schoolWebAppContext (DbContextOptions<schoolWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<schoolWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
