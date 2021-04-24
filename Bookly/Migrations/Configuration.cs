namespace Bookly.Migrations
{
    using Bookly.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bookly.Models.BookCbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bookly.Models.BookCbContext context)
        {
            context.Reservations.AddOrUpdate(x => x.ReservationsID,
                new Reservations() { ReservationsID = 20, BookID=2,ClientID=1,startDate=new DateTime(2017,11,10),endDate=new DateTime(2018,12,12)},
                new Reservations() { ReservationsID = 15, BookID = 1, ClientID = 2, startDate = new DateTime(2018, 11, 10), endDate = new DateTime(2020, 12, 12) }
                );
        }
    }
}
