using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;

    namespace ProductAPI.Data
{
    public class companyDBContext:DbContext
    {     

        public companyDBContext(DbContextOptions<companyDBContext>options):base(options)
        { 
            
        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Customer> CustomerInfo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p=>p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Customer>().Property(p => p.CreditLimit).HasColumnType("decimal(18,2)");
           
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(connString);
        }
    }
}
