﻿namespace WolffLogistics.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AccountNumber = c.String(),
                        CompanyName = c.String(),
                        RegistrationNumber = c.String(),
                        VatNumber = c.String(),
                        TelephoneNumber = c.String(),
                        Email = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        Province = c.String(),
                        PostalCode = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
