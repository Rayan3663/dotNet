using Microsoft.EntityFrameworkCore;
using FirstApp.Models;

namespace FirstApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

         
        }


        public DbSet<Category> Categories{ get; set; }
    }
}
