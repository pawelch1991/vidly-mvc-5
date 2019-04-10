namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4fdd1fbd-dadd-42a0-b071-b6d8c73dda7a', N'admin@vidly.com', 0, N'ADvD1MdpTP5BESLDqLUlwhLX1hElUnWqw2wA+Bftuky3nxsQyMe1rj1v4jCuUIL60A==', N'b1b919ce-f18f-47f3-afab-ac4340bf5e25', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a135317-2afd-4245-810a-0804b0120ca2', N'guest@vidly.com', 0, N'AIMTqn2cSkzK/HFK/Szfk0q7XxJGOSiXBbtI/3S6cSuiXUfxBHZv8kNBXCKWaROBUQ==', N'b1e427e9-e034-419e-a1ca-0306b1f985e0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c8563f0a-edf6-4d97-b499-9302448cedeb', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4fdd1fbd-dadd-42a0-b071-b6d8c73dda7a', N'c8563f0a-edf6-4d97-b499-9302448cedeb')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
