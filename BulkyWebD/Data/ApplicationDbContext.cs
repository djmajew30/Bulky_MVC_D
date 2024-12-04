using BulkyWebD.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebD.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; } //creates table on migration
    }
}
