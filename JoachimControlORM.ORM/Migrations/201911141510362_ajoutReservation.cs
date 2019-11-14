namespace JoachimControlORM.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutReservation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Client");
            DropColumn("dbo.Reservations", "Jeu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Jeu", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "Client", c => c.String(nullable: false));
        }
    }
}
