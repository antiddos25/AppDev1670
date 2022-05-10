using FBookStore.Models;
using Microsoft.EntityFrameworkCore;
namespace FBookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
