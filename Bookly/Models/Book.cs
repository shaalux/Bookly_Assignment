using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberInStock { get; set; }
    }
}