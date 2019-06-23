using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorioConPruebas.Repositorio;
using PatronRepositorioConPruebas.Entidades;

namespace ClientesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes.ClienteId = 1;
            clientes.Imagen_ImagenId = 1;
            Assert.IsTrue(repositorio.Guardar(clientes));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Clientes> repositorioBase;
            repositorioBase = new RepositorioBase<Clientes>();
            Assert.IsNotNull(repositorioBase.Buscar(1));
        }
        [TestMethod()]
        public void GetLista()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            Assert.IsNotNull(repositorio.GetList(t => true));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Clientes> repositorioBase;
            repositorioBase = new RepositorioBase<Clientes>();
            Clientes clientes = new Clientes();
            clientes.Imagen_ImagenId = 1;
            clientes.ClienteId = 2;

            repositorioBase.Modificar(clientes);
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Clientes> repos =
                new RepositorioBase<Clientes>();

            Assert.IsTrue(repos.Eliminar(2));
        }
    }
}
