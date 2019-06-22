using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using PatronRepositorioConPruebas.Entidades;

namespace PatronRepositorioConPruebas.DAL
{
   public class Contexto :  DbContext
    {
       public DbSet<Cargos> Cargos { get; set; }
       public DbSet<Categorias> Categorias { get; set; }
       public DbSet<Clientes> Clientes { get; set; }
       public DbSet<Compras> Compras { get; set; }
       public DbSet<Empleados> Empleados { get; set; }
       public DbSet<Estados> Estados { get; set; }
       public DbSet<Imagenes> Imagenes { get; set; }
       public DbSet<Marcas> Marcas { get; set; }
       public DbSet<Modelos> Modelos { get; set; }
       public DbSet<Permisos> Permisos { get; set; }
       public DbSet<Personas> Personas { get; set; }
       public DbSet<Productos> Productos { get; set; }
       public DbSet<Proovedor> proovedors { get; set; }
       public DbSet<TipoComprobante> tipoComprobantes { get; set; }
       public DbSet<TipoPersona> tipoPersonas { get; set; }
       public DbSet<UnidadMedida> unidadMedidas { get; set; }
       public DbSet<UsuarioHasPermiso> usuarioHasPermisos { get; set; }
       public DbSet<Usuarios> Usuarios { get; set; }
       public DbSet<Ventas> Ventas { get; set; }
        
       public Contexto() : base("ConStr")
        { }


    }
}
