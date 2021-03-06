namespace BlutChain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterCEPHemobanco : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hemobanco", "CEP", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hemobanco", "CEP", c => c.String(nullable: false, maxLength: 8));
        }
    }
}
