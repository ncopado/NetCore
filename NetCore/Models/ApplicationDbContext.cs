using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Album> Album { get; set; }
    }
}
