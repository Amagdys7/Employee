namespace Employee.BL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class country_city : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        countryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.countryID, cascadeDelete: true)
                .Index(t => t.countryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryNAme = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "countryID", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "countryID" });
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
