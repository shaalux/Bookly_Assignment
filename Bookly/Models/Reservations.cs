using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Reservations
    {
        [Key]
        public int ReservationsID { get; set; }
        public Book Book { get; set; }
        public int BookID { get; set; }
        public Client Client { get; set; }

        public int ClientID { get; set; }
        
        [Column(TypeName ="DateTime2")]
        public DateTime startDate { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime endDate { get; set; }
    }
}