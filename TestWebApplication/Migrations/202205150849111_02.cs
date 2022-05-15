namespace TestWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02 : DbMigration
    {
        public override void Up()
        {
            //Тестовые данные
            Sql("INSERT[dbo].[Employees]([ID], [FullName], [PhoneNumber], [Created], [Modified]) VALUES(N'd466adff-edce-45d2-a496-1b6f9ad05965', N'Семенов Семен Семенович', N'678', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Employees]([ID], [FullName], [PhoneNumber], [Created], [Modified]) VALUES(N'c0994849-6d67-4971-9ed3-3639b02561af', N'Иванов Иван Иванович', N'123', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Employees]([ID], [FullName], [PhoneNumber], [Created], [Modified]) VALUES(N'0086bea2-d8eb-4198-b322-98b8699d6808', N'Петров Петр Петрович', N'345', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Employees]([ID], [FullName], [PhoneNumber], [Created], [Modified]) VALUES(N'9d97619b-38d7-4ca1-a0ac-e457e184cb97', N'Александров Сан Саныч', N'901', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Groups]([ID], [Name], [Created], [Modified]) VALUES(N'13292eba-e1b0-4b54-9fa6-4095c8801549', N'Руководство', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Groups]([ID], [Name], [Created], [Modified]) VALUES(N'060ba937-6aae-4ac8-a357-578638b3f32a', N'Разработчики', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Groups]([ID], [Name], [Created], [Modified]) VALUES(N'7dcec86a-0fda-400a-95ae-8e3d5a67a204', N'Администраторы', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[Groups]([ID], [Name], [Created], [Modified]) VALUES(N'ebdd82e7-ae62-4934-b3eb-d0a1c6294c7d', N'Инженеры', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[EmployeeOfGroups]([ID], [Employee_ID], [Group_ID], [Created], [Modified]) VALUES(N'0c9503d6-3f0d-4dad-863b-2736d440ddd8', N'0086bea2-d8eb-4198-b322-98b8699d6808', N'13292eba-e1b0-4b54-9fa6-4095c8801549', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[EmployeeOfGroups]([ID], [Employee_ID], [Group_ID], [Created], [Modified]) VALUES(N'8a5a91b0-12ef-4772-9914-4df91f69c539', N'9d97619b-38d7-4ca1-a0ac-e457e184cb97', N'ebdd82e7-ae62-4934-b3eb-d0a1c6294c7d', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[EmployeeOfGroups]([ID], [Employee_ID], [Group_ID], [Created], [Modified]) VALUES(N'0c82f116-9fc4-4d25-9bc6-8b4bbd91ca00', N'd466adff-edce-45d2-a496-1b6f9ad05965', N'060ba937-6aae-4ac8-a357-578638b3f32a', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[EmployeeOfGroups]([ID], [Employee_ID], [Group_ID], [Created], [Modified]) VALUES(N'aa45594b-c26e-4174-9866-a10869b8f925', N'd466adff-edce-45d2-a496-1b6f9ad05965', N'ebdd82e7-ae62-4934-b3eb-d0a1c6294c7d', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[EmployeeOfGroups]([ID], [Employee_ID], [Group_ID], [Created], [Modified]) VALUES(N'a6541963-2152-4098-8e54-f06c50f07f1a', N'9d97619b-38d7-4ca1-a0ac-e457e184cb97', N'13292eba-e1b0-4b54-9fa6-4095c8801549', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");
            Sql("INSERT[dbo].[EmployeeOfGroups]([ID], [Employee_ID], [Group_ID], [Created], [Modified]) VALUES(N'42b6989a-85e4-49d2-853c-f532922eea53', N'c0994849-6d67-4971-9ed3-3639b02561af', N'7dcec86a-0fda-400a-95ae-8e3d5a67a204', CAST(N'2022-05-15T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime))");

        }
        
        public override void Down()
        {
        }
    }
}
