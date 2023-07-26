using Microsoft.EntityFrameworkCore;

namespace CQRS_Casgem.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-D19MH5E\\SQLEXPRESS;initial catalog=CasgemCQRS;integrated security=true");
        }

        public DbSet<Product> Products { get; set; }

    }
    
    
}
