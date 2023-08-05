using GroceryWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<List> Lists { get; set; }
    }
}
