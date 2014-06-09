using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MF0493_3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class EmpresaManagerTest
    {
        [TestMethod]
        public void getTest()
        {
            MF0493Entities db = new MF0493Entities();

            var data = from empresa in db.Empresas
                       select empresa;

            Empresa emp = data.First();

            Empresa final = EmpresaManager.get(emp.nif);

            bool resultado = false;
            if (final.nif != null)
            {
                resultado = true;
            }
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void NuevaTest()
        {
            Empresa emp = new Empresa();
            emp.nif = "1111111A";
            emp.nombre = "Prueba";
            emp.email = "Prueba@hotmail.com";
            emp.telefono = "111111111";
            emp.usr = "admin";

            EmpresaManager.Nueva(emp);

            Empresa resultado = EmpresaManager.get(emp.nif);

            Assert.AreEqual(resultado.nif, emp.nif);
        }
        [TestMethod]
        public void ModificarTest()
        {
            Empresa emp = new Empresa();
            emp.nif = "1111111A";
            emp.nombre = "Modificado";
            emp.email = "Prueba@hotmail.com";
            emp.telefono = "111111111";
            emp.usr = "admin";

            EmpresaManager.Modificar(emp);

            Empresa resultado = EmpresaManager.get(emp.nif);

            Assert.AreEqual(resultado.nombre, emp.nombre);
        }

        [TestMethod]
        public void EliminarTest()
        { 
            string nif = "1111111A";
            bool borrar = EmpresaManager.Eliminar(nif);



            Assert.AreEqual(borrar,true);

        }
    }
}
