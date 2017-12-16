namespace Dominio.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _1 : DbMigration
  {
    public override void Up()
    {
      //RenameTable(name: "dbo.SysUsers", newName: "SystemUsers");

      CreateTable(
          "dbo.SystemUsers",
          c => new
          {
            Codigo = c.Int(nullable: false, identity: true),
            LoginName = c.String(),
            PasswordEncryptedText = c.String(),
            RowCreatedSYSUserID = c.Int(nullable: false),
            RowCreatedDateTime = c.DateTime(nullable: false),
            RowModifiedSYSUserID = c.Int(nullable: false),
            RowModifiedDateTime = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.Codigo);

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
            SystemUserID = c.Int(nullable: false),
            FirstName = c.String(),
            LastName = c.String(),
            RowCreatedSYSUserID = c.Int(nullable: false),
            RowCreatedDateTime = c.DateTime(nullable: false),
            RowModifiedSysUserID = c.Int(nullable: false),
            RowModifiedDateTime = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.Codigo)
          .ForeignKey("dbo.SystemUsers", t => t.SystemUserID, cascadeDelete: true)
          .Index(t => t.SystemUserID);

      CreateTable(
          "dbo.SysUserRoles",
          c => new
          {
            Codigo = c.Int(nullable: false, identity: true),
            SystemUserID = c.Int(nullable: false),
            LookUpRoleID = c.Int(nullable: false),
            IsActive = c.Boolean(nullable: false),
            RowCreatedSysUserID = c.Int(nullable: false),
            RowCreatedDateTime = c.DateTime(nullable: false),
            RowModifiedSYSUserID = c.Int(nullable: false),
            RowModifiedDateTime = c.DateTime(nullable: false),
          })
          .PrimaryKey(t => t.Codigo)
          .ForeignKey("dbo.LookUpRoles", t => t.LookUpRoleID, cascadeDelete: true)
          .ForeignKey("dbo.SystemUsers", t => t.SystemUserID, cascadeDelete: true)
          .Index(t => t.SystemUserID)
          .Index(t => t.LookUpRoleID);

    }

    public override void Down()
    {
      DropForeignKey("dbo.SysUserRoles", "SystemUserID", "dbo.SystemUsers");
      DropForeignKey("dbo.SysUserRoles", "LookUpRoleID", "dbo.LookUpRoles");
      DropForeignKey("dbo.SysUserProfiles", "SystemUserID", "dbo.SystemUsers");
      DropIndex("dbo.SysUserRoles", new[] { "LookUpRoleID" });
      DropIndex("dbo.SysUserRoles", new[] { "SystemUserID" });
      DropIndex("dbo.SysUserProfiles", new[] { "SystemUserID" });
      DropTable("dbo.SysUserRoles");
      DropTable("dbo.SysUserProfiles");
      DropTable("dbo.LookUpRoles");
      DropTable("dbo.SystemUsers");
      //RenameTable(name: "dbo.SystemUsers", newName: "SysUsers");
    }
  }
}
