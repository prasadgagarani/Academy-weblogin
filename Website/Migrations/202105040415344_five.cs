namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class five : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        First_name = c.String(nullable: false),
                        Last_name = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                        Contact = c.Long(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        userCategory = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        RegistrationStatus = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Faculties");
        }
    }
}
