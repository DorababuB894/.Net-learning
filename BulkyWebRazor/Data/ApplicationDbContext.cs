
using Microsoft.EntityFrameworkCore;
using BulkyWebRazor.Model;

namespace BulkyWebRazor.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1, Description = "my movies" },
                new Category { CategoryId = 2, Name = "Scifi", DisplayOrder = 2, Description = "my scifi movies" },
                new Category { CategoryId = 3, Name = "Comedy", DisplayOrder = 3, Description = "action movies" }
            );
        }

    }
}
