using Bulkyweb.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Bulkyweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Bulkyweb.Models.Category> Categories { get; set; }

        // Fixed: Renamed to PascalCase and provided an empty method body to satisfy CS0501 and IDE1006
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 ,Description="my movies"},
                new Category { CategoryId = 2, Name = "Scifi", DisplayOrder = 2, Description = "my scifi movies" },
                new Category { CategoryId = 3, Name = "Comedy", DisplayOrder = 3, Description = "action movies" }

            );
        }
    }
}
