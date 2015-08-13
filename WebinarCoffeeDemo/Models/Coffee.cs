using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebinarCoffeeDemo.Models
{
    public class Coffee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public Company Company { get; set; }
    }
}