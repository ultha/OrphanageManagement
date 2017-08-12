namespace OrphanangeSystem1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        DonatingAmount = c.String(),
                        FeildToSpend = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orphans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Disable = c.Boolean(nullable: false),
                        JoinedDate = c.DateTime(nullable: false),
                        LeaveDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orphans");
            DropTable("dbo.Donators");
        }
    }
}
