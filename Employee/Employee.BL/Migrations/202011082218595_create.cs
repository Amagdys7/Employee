namespace Employee.BL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeNs",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        EmailAddress = c.String(nullable: false),
                        ConfirmEmailAddress = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        URL = c.String(),
                        Gender = c.String(),
                        Salary = c.Double(nullable: false),
                        isactive = c.Boolean(nullable: false),
                        isalive = c.Boolean(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeNs");
        }
    }
}
