namespace FPT_Training_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'826d1fe3-e213-4bca-9d24-9b1ce2ae1c7e', N'admin@admin.com', 0, N'AIjISQoMZln+rO9mw+Y+Lcj8Ep/n36S9NXhoyOmHmBaeNTMp7SLmjUGwquSe4J8MKQ==', N'1f2440b0-01e5-49b3-b86e-c4d25854bcee', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'87295bf8-3090-4e50-8630-42a94f8bf22d', N'admin@gmail.com', 0, N'AE4IgtU2w31N5m+p9JV2vFWYjs7JFNQ8gTlFoOQygB4Ci+YjXfv64SkCwA6jNGGBVw==', N'cbef22a4-b344-4085-909c-4c2d93eadff3', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c749e762-1d56-44f7-b3b7-a930fceb4d15', N'admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'826d1fe3-e213-4bca-9d24-9b1ce2ae1c7e', N'c749e762-1d56-44f7-b3b7-a930fceb4d15')

");
        }
        
        public override void Down()
        {
        }
    }
}
