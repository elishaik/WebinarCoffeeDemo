using System.Data.Entity;

namespace WebinarCoffeeDemo.Models
{
    public class WebinarCoffeeDemoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebinarCoffeeDemoContext() : base("name=WebinarCoffeeDemoContext")
        {
        }

        public DbSet<Coffee> Coffees { get; set; }

        public DbSet<Company> Companies { get; set; }
    }
}
