namespace sales.Domain.Models
{
    using System.Data.Entity;
    using sales.Common.Models;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
    } 
}
