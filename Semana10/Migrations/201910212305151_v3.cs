namespace Semana10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Active", c => c.Int());
            DropColumn("dbo.People", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Activo", c => c.Int());
            DropColumn("dbo.People", "Active");
        }
    }
}
