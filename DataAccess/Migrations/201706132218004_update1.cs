namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Make = c.String(nullable: false, maxLength: 128),
                        Model = c.String(),
                        Color = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TCC_Rating = c.Double(nullable: false),
                        MPG = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Make);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
