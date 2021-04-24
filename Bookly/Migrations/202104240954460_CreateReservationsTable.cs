namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateReservationsTable : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Reservations", "BookID", "dbo.Books");
            //DropForeignKey("dbo.Reservations", "ClientID", "dbo.Clients");
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationsID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        endDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ReservationsID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true);
            
            //DropTable("dbo.Reservations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationsID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(nullable: false),
                        ClientID = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        EndDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ReservationsID);
            
            DropForeignKey("dbo.Reservations", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "BookID", "dbo.Books");
            DropTable("dbo.Reservations");
            AddForeignKey("dbo.Reservations", "ClientID", "dbo.Clients", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "BookID", "dbo.Books", "ID", cascadeDelete: true);
        }
    }
}
