namespace Backend.Data
{
 
    using Microsoft.EntityFrameworkCore;
    using Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Client> Clientes { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }

}
