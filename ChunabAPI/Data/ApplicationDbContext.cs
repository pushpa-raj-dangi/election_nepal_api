using ChunabAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChunabAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      :base(options)
    { }

        public DbSet<Party> Parties {get;set;}
    }
}