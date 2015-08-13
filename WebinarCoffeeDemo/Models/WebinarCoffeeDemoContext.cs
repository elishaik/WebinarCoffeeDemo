using System.Data.Entity;

namespace WebinarCoffeeDemo.Models
{
    public class WebinarCoffeeDemoContext : DbContext
    {
        public WebinarCoffeeDemoContext() : base("name=WebinarCoffeeDemoContext")
        {
        }

        public DbSet<Coffee> Coffees { get; set; }

        public DbSet<Company> Companies { get; set; }
    }
}
