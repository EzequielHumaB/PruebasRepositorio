using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorioConPruebas.Repositorio;
using PatronRepositorioConPruebas.Entidades;
using PatronRepositorioConPruebas.DAL;
using System.Linq.Expressions;
using System.Linq;
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
        public void Buscar()
        {
            RepositorioBase<Cargos> repositorioBase;
            repositorioBase = new RepositorioBase<Cargos>();
            Assert.IsNotNull(repositorioBase.Buscar(7));
        }
        [TestMethod()]
        public void GetLista()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Assert.IsNotNull(repositorio.GetList(t => true));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Cargos> repositorioBase;
            repositorioBase = new RepositorioBase<Cargos>();
            Cargos cargos = new Cargos();
            cargos.CargoId = 7;
            cargos.NombreCargo = "Nombre";
            cargos.Estado_EstadoId = 12;
            repositorioBase.Modificar(cargos);
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Cargos> repos = 
                new RepositorioBase<Cargos>();
           
            Assert.IsTrue(repos.Eliminar(7));
         }
       
    }
}
