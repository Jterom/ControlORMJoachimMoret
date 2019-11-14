namespace JoachimControlORM.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajoutLiaison : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JeuClients", "Jeu_IdJeu", "dbo.Jeus");
            DropForeignKey("dbo.JeuClients", "Client_IdClient", "dbo.Clients");
            DropIndex("dbo.JeuClients", new[] { "Jeu_IdJeu" });
            DropIndex("dbo.JeuClients", new[] { "Client_IdClient" });
            CreateTable(
                "dbo.lienJeuClients",
                c => new
                    {
                        IdLienJeuClient = c.Int(nullable: false, identity: true),
                        echange = c.Boolean(nullable: false),
                        aquisition = c.Boolean(nullable: false),
                        Clients_IdClient = c.Int(),
                        Jeus_IdJeu = c.Int(),
                    })
                .PrimaryKey(t => t.IdLienJeuClient)
                .ForeignKey("dbo.Clients", t => t.Clients_IdClient)
                .ForeignKey("dbo.Jeus", t => t.Jeus_IdJeu)
                .Index(t => t.Clients_IdClient)
                .Index(t => t.Jeus_IdJeu);
            
            AddColumn("dbo.Jeus", "Client_IdClient", c => c.Int());
            CreateIndex("dbo.Jeus", "Client_IdClient");
            AddForeignKey("dbo.Jeus", "Client_IdClient", "dbo.Clients", "IdClient");
            DropTable("dbo.JeuClients");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.JeuClients",
                c => new
                    {
                        Jeu_IdJeu = c.Int(nullable: false),
                        Client_IdClient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Jeu_IdJeu, t.Client_IdClient });
            
            DropForeignKey("dbo.lienJeuClients", "Jeus_IdJeu", "dbo.Jeus");
            DropForeignKey("dbo.lienJeuClients", "Clients_IdClient", "dbo.Clients");
            DropForeignKey("dbo.Jeus", "Client_IdClient", "dbo.Clients");
            DropIndex("dbo.lienJeuClients", new[] { "Jeus_IdJeu" });
            DropIndex("dbo.lienJeuClients", new[] { "Clients_IdClient" });
            DropIndex("dbo.Jeus", new[] { "Client_IdClient" });
            DropColumn("dbo.Jeus", "Client_IdClient");
            DropTable("dbo.lienJeuClients");
            CreateIndex("dbo.JeuClients", "Client_IdClient");
            CreateIndex("dbo.JeuClients", "Jeu_IdJeu");
            AddForeignKey("dbo.JeuClients", "Client_IdClient", "dbo.Clients", "IdClient", cascadeDelete: true);
            AddForeignKey("dbo.JeuClients", "Jeu_IdJeu", "dbo.Jeus", "IdJeu", cascadeDelete: true);
        }
    }
}
