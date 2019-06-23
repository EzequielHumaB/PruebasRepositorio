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
            Cargos cargos = new Cargos();
            cargos.CargoId = 1;
            cargos.Estado_EstadoId = 12;
            cargos.NombreCargo = "Nombre";
          
            Assert.IsTrue(repositorio.Guardar(cargos));
           
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Cargos> repos = 
                new RepositorioBase<Cargos>();
           
            Assert.IsTrue(repos.Eliminar(3));
         }
       
    }
}
