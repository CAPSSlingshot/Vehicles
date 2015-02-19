namespace Vehicles.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        Vin = c.String(),
                        Year = c.Int(nullable: false),
                        Make = c.String(),
                        ModelType = c.String(),
                        Owner_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.VehicleId)
                .ForeignKey("dbo.Person", t => t.Owner_PersonId)
                .Index(t => t.Owner_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "Owner_PersonId", "dbo.Person");
            DropIndex("dbo.Vehicle", new[] { "Owner_PersonId" });
            DropTable("dbo.Vehicle");
            DropTable("dbo.Person");
        }
    }
}
