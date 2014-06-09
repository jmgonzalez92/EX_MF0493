using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MF0493_3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void CrearAdminTest()
        {
            string username = "admin";
            UserManager.CrearAdmin();

            Usuario  u = UserManager.get(username);

            Assert.AreEqual(u.username, "admin" , "No existe un usuario Admin");
        }

        [TestMethod]
        public void getAllTest()
        {
            MF0493Entities db = new MF0493Entities();
            var data = from usuarios in db.Usuarios
                       select usuarios;

            int totala = data.Count();
            

            List<Usuario> lst = UserManager.getAll();

            int totalb = lst.Count();

            Assert.AreEqual(totala, totalb);
        } 
    }
}
