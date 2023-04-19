using ApiTestingWithEntity.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiTestingWithEntity.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<BooksModel> books { get; set; }
    }
}
