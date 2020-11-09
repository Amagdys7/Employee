namespace Employee.BL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "MyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cities", "Mytime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.EmployeeNs", "Time", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeNs", "Time");
            DropColumn("dbo.Cities", "Mytime");
            DropColumn("dbo.Cities", "MyDate");
        }
    }
}
