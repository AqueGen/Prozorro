namespace Kapitalist.Data.Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DraftTenderAwardCriteria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DraftTenders", "AwardCriteria", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DraftTenders", "AwardCriteria");
        }
    }
}
