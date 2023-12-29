using Microsoft.EntityFrameworkCore;


namespace EFManyToMany.Models.ORM
{
    public class WebuserDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-13V6IU8;Database=TechCareer;Trusted_Connection=True;");
        }
        
        public DbSet<Webuser> WebUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
