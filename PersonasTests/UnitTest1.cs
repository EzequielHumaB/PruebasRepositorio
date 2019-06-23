using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorioConPruebas.Entidades;
using PatronRepositorioConPruebas.Repositorio;
using System.Data.Entity;


namespace PersonasTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Personas personas = new Personas();
            personas.idPersona = 1;
            personas.nombre = "Nombre";
            Assert.IsTrue(repositorio.Guardar(personas));
        }

       [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Personas> repositorioBase;
            repositorioBase = new RepositorioBase<Personas>();
            Assert.IsNotNull(repositorioBase.Buscar(2));
        }
        [TestMethod()]
        public void GetLista()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsNotNull(repositorio.GetList(t => true));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Personas> repositorioBase;
            repositorioBase = new RepositorioBase<Personas>();
            Personas personas = new Personas();
            personas.idPersona = 2;
            personas.nombre = "Nombre";
   
            repositorioBase.Modificar(personas);
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Personas> repos =
                new RepositorioBase<Personas>();

            Assert.IsTrue(repos.Eliminar(4));
        }

    }
}
