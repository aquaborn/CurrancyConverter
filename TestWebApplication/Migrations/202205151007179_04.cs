namespace TestWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE[dbo].[Groups] SET[GroupType] = 0  WHERE Id = '13292EBA-E1B0-4B54-9FA6-4095C8801549'");
            Sql("UPDATE[dbo].[Groups] SET[GroupType] = 1  WHERE Id = '7DCEC86A-0FDA-400A-95AE-8E3D5A67A204'");
            Sql("UPDATE[dbo].[Groups] SET[GroupType] = 2  WHERE Id = 'EBDD82E7-AE62-4934-B3EB-D0A1C6294C7D'");
            Sql("UPDATE[dbo].[Groups] SET[GroupType] = 3  WHERE Id = '060BA937-6AAE-4AC8-A357-578638B3F32A'");
            Sql("UPDATE[dbo].[Employees] SET[Email] = 'semenov@yandex.ru' WHERE Id = 'D466ADFF-EDCE-45D2-A496-1B6F9AD05965'");
            Sql("UPDATE[dbo].[Employees] SET[Email] = 'ivanov@yandex.ru' WHERE Id = 'C0994849-6D67-4971-9ED3-3639B02561AF'");
            Sql("UPDATE[dbo].[Employees] SET[Email] = 'petrov@yandex.ru' WHERE Id = '0086BEA2-D8EB-4198-B322-98B8699D6808'");
            Sql("UPDATE[dbo].[Employees] SET[Email] = 'alexandrov@yandex.ru' WHERE Id = '9D97619B-38D7-4CA1-A0AC-E457E184CB97'");

        }

        public override void Down()
        {
        }
    }
}
