using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorioConPruebas.Repositorio;
using PatronRepositorioConPruebas.Entidades;
using PatronRepositorioConPruebas.DAL;
namespace PruebasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
     
           // Assert.IsTrue(repositorio.Guardar(new Cargos()));
            Assert.IsTrue(repositorio.Guardar(new Cargos()));
            //  Assert.IsTrue(repositorio.Modificar(new Personas())); 
        }

        public void textMethod1()
        {
            RepositorioBase<Proovedor> repositorio;
            repositorio = new RepositorioBase<Proovedor>();

            Assert.IsTrue(repositorio.Modificar(new Proovedor()));
        }

       
    }
}
