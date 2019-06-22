using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Fabricacion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double CostoCompra { get; set; }
        public double stock { get; set; }
        public int UnidadMedida_UnidadMedidaId { get; set; }
        public int Imagen_ImagenId { get; set; }
        public int Categoria_CategoriaId { get; set; }
        public int Marca_MarcaId { get; set; }
        public int Modelo_ModeloId { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Nombre = string.Empty;
            Fabricacion = string.Empty;
            FechaFabricacion = DateTime.Now;
            CostoCompra = 0.0;
            stock = 0.0;
            UnidadMedida_UnidadMedidaId = 0;
            Imagen_ImagenId = 0;
            Categoria_CategoriaId = 0;
            Marca_MarcaId = 0;
            Modelo_ModeloId = 0;
        }


    }
}
