namespace Manager.Migrations
{
    using Manager.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Manager.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Manager.Models.ApplicationDbContext context)
        {
            this.AddUserAndRoles();
        }

        bool AddUserAndRoles()
        {
            bool success = false;

            #region crea roles

            var idManager = new IdentityManager();
            success = idManager.CreateRole("sistema");
            if (!success == true) return success;

            success = idManager.CreateRole("administrador");
            if (!success == true) return success;

            success = idManager.CreateRole("usuario");
            if (!success) return success;

            #endregion

            #region crea usuarios

            //usuario administrador del sistema
            var newUserSistema = new ApplicationUser() { UserName = "sysadmin" };
            success = idManager.CreateUser(newUserSistema, "123456a");
            if (!success) return success;
            success = idManager.AddUserToRole(newUserSistema.Id, "sistema");
            if (!success) return success;

            //usuario administrador de tiendas
            var newUserAdministrador = new ApplicationUser() { UserName = "hfuentes" };
            success = idManager.CreateUser(newUserAdministrador, "123456a");
            if (!success) return success;
            success = idManager.AddUserToRole(newUserAdministrador.Id, "administrador");
            if (!success) return success;

            #endregion

            return success;
        }
    }
}
