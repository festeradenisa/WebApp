using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCrud.Models;

namespace WebAppCrud.Data
{
    public class WebAppCrudContext : DbContext
    {
        public WebAppCrudContext (DbContextOptions<WebAppCrudContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCrud.Models.Album> Album { get; set; } = default!;

        public DbSet<WebAppCrud.Models.Artist> Artist { get; set; }
    }
}
