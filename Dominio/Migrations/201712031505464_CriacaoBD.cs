namespace Dominio.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class CriacaoBD : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.SysUsers",
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

    }

    public override void Down()
    {
      DropTable("dbo.SysUsers");
    }
  }
}
