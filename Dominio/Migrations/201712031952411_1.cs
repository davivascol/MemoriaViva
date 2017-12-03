namespace Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LookUpRoles",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleDescription = c.String(),
                        RowCreatedSYSUserID = c.Int(nullable: false),
                        RowCreatedDateTime = c.DateTime(nullable: false),
                        RowModifiedSYSUserID = c.Int(nullable: false),
                        RowModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.SysUserProfiles",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        SysUserID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        RowCreatedSYSUserID = c.Int(nullable: false),
                        RowCreatedDateTime = c.DateTime(nullable: false),
                        RowModifiedSysUserID = c.Int(nullable: false),
                        RowModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.SysUsers", t => t.SysUserID, cascadeDelete: true)
                .Index(t => t.SysUserID);
            
            CreateTable(
                "dbo.SysUserRoles",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        SysUserID = c.Int(nullable: false),
                        LookUpRoleID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        RowCreatedSysUserID = c.Int(nullable: false),
                        RowCreatedDateTime = c.DateTime(nullable: false),
                        RowModifiedSYSUserID = c.Int(nullable: false),
                        RowModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.LookUpRoles", t => t.LookUpRoleID, cascadeDelete: true)
                .ForeignKey("dbo.SysUsers", t => t.SysUserID, cascadeDelete: true)
                .Index(t => t.SysUserID)
                .Index(t => t.LookUpRoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SysUserRoles", "SysUserID", "dbo.SysUsers");
            DropForeignKey("dbo.SysUserRoles", "LookUpRoleID", "dbo.LookUpRoles");
            DropForeignKey("dbo.SysUserProfiles", "SysUserID", "dbo.SysUsers");
            DropIndex("dbo.SysUserRoles", new[] { "LookUpRoleID" });
            DropIndex("dbo.SysUserRoles", new[] { "SysUserID" });
            DropIndex("dbo.SysUserProfiles", new[] { "SysUserID" });
            DropTable("dbo.SysUserRoles");
            DropTable("dbo.SysUserProfiles");
            DropTable("dbo.LookUpRoles");
        }
    }
}
