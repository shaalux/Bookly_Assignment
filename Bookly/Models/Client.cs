using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Column(TypeName ="DateTime2")]
        public DateTime DateOfBirth { get; set; }

        public string Type { get; set; }

    }
}