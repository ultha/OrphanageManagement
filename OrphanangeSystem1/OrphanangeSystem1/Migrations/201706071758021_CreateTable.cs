namespace OrphanangeSystem1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdoptorRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        EmailAddress = c.String(),
                        ContactNo = c.String(),
                        Married = c.String(),
                        DateOfMarriage = c.DateTime(nullable: false),
                        Profession = c.String(),
                        MonthlyIncome = c.Int(nullable: false),
                        ReasonOfAdoption = c.String(),
                        IfAnyChild = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ContactNo = c.String(),
                        Address = c.String(),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EventToGetInvolved = c.String(),
                        Date = c.DateTime(nullable: false),
                        EmailNotification = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Volunteers");
            DropTable("dbo.Sponsors");
            DropTable("dbo.AdoptorRequests");
            DropTable("dbo.Admins");
        }
    }
}
