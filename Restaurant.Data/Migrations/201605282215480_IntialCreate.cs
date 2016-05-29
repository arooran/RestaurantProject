namespace Restaurant.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BranchAddresses",
                c => new
                    {
                        BranchAddressId = c.Int(nullable: false),
                        UniqueKey = c.Guid(nullable: false),
                        BuildingNumber = c.String(maxLength: 256),
                        Town = c.String(),
                        Street = c.String(),
                        City = c.String(maxLength: 128),
                        County = c.String(),
                        PostCode = c.String(),
                        Longitude = c.String(),
                        Latitude = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        IP = c.String(),
                        CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.BranchAddressId)
                .ForeignKey("dbo.Branches", t => t.BranchAddressId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.BranchAddressId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        UniqueKey = c.Guid(nullable: false),
                        BranchName = c.String(nullable: false, maxLength: 512),
                        IsDeliveryEnabled = c.Boolean(nullable: false),
                        MaxDeliveryDistance = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        BranchAddressId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        PhoneNumberId = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 100),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        IP = c.String(),
                        BranchId = c.Int(),
                        PhoneNumberTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneNumberId)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.PhoneNumberTypes", t => t.PhoneNumberTypeId)
                .Index(t => t.BranchId)
                .Index(t => t.PhoneNumberTypeId);
            
            CreateTable(
                "dbo.PhoneNumberTypes",
                c => new
                    {
                        PhoneNumberTypeId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 128),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.PhoneNumberTypeId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 256),
                        Code = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddressTypeId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 512),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.AddressTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BranchAddresses", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.PhoneNumbers", "PhoneNumberTypeId", "dbo.PhoneNumberTypes");
            DropForeignKey("dbo.PhoneNumbers", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.BranchAddresses", "BranchAddressId", "dbo.Branches");
            DropIndex("dbo.PhoneNumbers", new[] { "PhoneNumberTypeId" });
            DropIndex("dbo.PhoneNumbers", new[] { "BranchId" });
            DropIndex("dbo.BranchAddresses", new[] { "CountryId" });
            DropIndex("dbo.BranchAddresses", new[] { "BranchAddressId" });
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Countries");
            DropTable("dbo.PhoneNumberTypes");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Branches");
            DropTable("dbo.BranchAddresses");
        }
    }
}
