namespace TestWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Guid(nullable: false, defaultValueSql: "NEWID()"),
                        FullName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmployeeOfGroups",
                c => new
                    {
                        ID = c.Guid(nullable: false, defaultValueSql: "NEWID()"),
                        Employee_ID = c.Guid(nullable: false),
                        Group_ID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_ID, cascadeDelete: true)
                .Index(t => new { t.Employee_ID, t.Group_ID }, unique: true, name: "IX_EMPLOYEEOFGROUP");
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Guid(nullable: false, defaultValueSql: "NEWID()"),
                        Name = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeOfGroups", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.EmployeeOfGroups", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.EmployeeOfGroups", "IX_EMPLOYEEOFGROUP");
            DropTable("dbo.Groups");
            DropTable("dbo.EmployeeOfGroups");
            DropTable("dbo.Employees");
        }
    }
}
