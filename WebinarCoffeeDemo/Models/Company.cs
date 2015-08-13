using System.ComponentModel.DataAnnotations;

namespace WebinarCoffeeDemo.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
    }
}