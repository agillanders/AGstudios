namespace AGstudios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class people : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        HouseNameNumber = c.String(),
                        StreetName = c.String(),
                        Town = c.String(),
                        County = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
