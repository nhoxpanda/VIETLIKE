namespace CRM.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vs104 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_UpdateHistory", "QuotationId", c => c.Int());
            AddColumn("dbo.tbl_UpdateHistory", "HistoryId", c => c.Int());
            AddColumn("dbo.tbl_UpdateHistory", "DocumentFileId", c => c.Int());
            AddColumn("dbo.tbl_UpdateHistory", "TicketId", c => c.Int());
            CreateIndex("dbo.tbl_UpdateHistory", "QuotationId");
            CreateIndex("dbo.tbl_UpdateHistory", "HistoryId");
            CreateIndex("dbo.tbl_UpdateHistory", "DocumentFileId");
            CreateIndex("dbo.tbl_UpdateHistory", "TicketId");
            AddForeignKey("dbo.tbl_UpdateHistory", "HistoryId", "dbo.tbl_ContactHistory", "Id");
            AddForeignKey("dbo.tbl_UpdateHistory", "DocumentFileId", "dbo.tbl_DocumentFile", "Id");
            AddForeignKey("dbo.tbl_UpdateHistory", "QuotationId", "dbo.tbl_Quotation", "Id");
            AddForeignKey("dbo.tbl_UpdateHistory", "TicketId", "dbo.tbl_Ticket", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_UpdateHistory", "TicketId", "dbo.tbl_Ticket");
            DropForeignKey("dbo.tbl_UpdateHistory", "QuotationId", "dbo.tbl_Quotation");
            DropForeignKey("dbo.tbl_UpdateHistory", "DocumentFileId", "dbo.tbl_DocumentFile");
            DropForeignKey("dbo.tbl_UpdateHistory", "HistoryId", "dbo.tbl_ContactHistory");
            DropIndex("dbo.tbl_UpdateHistory", new[] { "TicketId" });
            DropIndex("dbo.tbl_UpdateHistory", new[] { "DocumentFileId" });
            DropIndex("dbo.tbl_UpdateHistory", new[] { "HistoryId" });
            DropIndex("dbo.tbl_UpdateHistory", new[] { "QuotationId" });
            DropColumn("dbo.tbl_UpdateHistory", "TicketId");
            DropColumn("dbo.tbl_UpdateHistory", "DocumentFileId");
            DropColumn("dbo.tbl_UpdateHistory", "HistoryId");
            DropColumn("dbo.tbl_UpdateHistory", "QuotationId");
        }
    }
}
