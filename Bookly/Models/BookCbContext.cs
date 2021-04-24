using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class BookCbContext : DbContext
    {
        public BookCbContext() : base("BooklyConnection")
        {
            
        }

        public DbSet <Book> Book { get; set; }
        public DbSet <Client> Client { get; set; }
        public DbSet <Reservations> Reservations { get; set; }
        
    }

}