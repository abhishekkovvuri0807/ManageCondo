using Microsoft.EntityFrameworkCore;

namespace ManageCondo.DomainLayer
{
    public class ManageCondoContext : DbContext
    {
        public DbSet<Property> Property { get; set; }

        public DbSet<Unit> Unit { get; set; }






        public ManageCondoContext(DbContextOptions<ManageCondoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-56UO2U1;Database=ManageCondo;Trusted_Connection=True;");
        }
    }
}