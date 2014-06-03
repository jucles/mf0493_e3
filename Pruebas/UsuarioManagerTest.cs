using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_e3.Models;

namespace Pruebas
{
    /// <summary>
    /// Summary description for UsuarioManagerTest
    /// </summary>
    [TestClass]
    public class UsuarioManagerTest
    {

        [TestMethod]
        public void getUsuarioTest(string dni)
        {

            usuario u = UsuarioManager.getUsuario("kkk");

            Assert.IsNull(u);

            u = UsuarioManager.getUsuario("admin");

            Assert.IsNotNull(u);
            Assert.IsTrue(u.activo);
            Assert.AreEqual(u.password, "aaa111...");

        }

    }
}
