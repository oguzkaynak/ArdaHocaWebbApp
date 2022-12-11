namespace ArdaHocaWebbApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArdaHocaWebbApp.Models.ArdaHocaModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ArdaHocaWebbApp.Models.ArdaHocaModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.ManagerTypes.AddOrUpdate(n => n.ID, new Models.ManagerTypes() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(n => n.ID, new Models.ManagerTypes() { ID = 2, Name = "Moderatör" });
            context.Managers.AddOrUpdate(n => n.ID, new Models.Manager() { ID = 1, Name = "Oguzhan", Surname = "Kaynak", Mail = "oguz-kaynak@hotmail.com", ManagerTypes_ID = 1, Password = "12345678", UserName = "ozi", IsActive = true });
        }
    }
}
