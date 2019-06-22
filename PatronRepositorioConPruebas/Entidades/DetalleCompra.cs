using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class DetalleCompra
    {
        [Key]
        public int DetalleCompraId { get; set; }
        public int Compra_CompraId { get; set; }
        public int Producto_ProductoId { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double Total { get; set; }

        public DetalleCompra()
        {
            DetalleCompraId = 0;
            Compra_CompraId = 0;
            Producto_ProductoId = 0;
            Unidades = 0.0d;
            CostoUnidad = 0.0d;
            Total = 0.0d;
        }
        public DetalleCompra(int compraDetalleId,int Compra_idCompra,int Producto_IdProductos,double unidades,double unidadcosto, double montototal)
        {
            DetalleCompraId = compraDetalleId;
            Compra_CompraId = Compra_idCompra;
            Producto_ProductoId = Producto_IdProductos;
            Unidades = unidades;
            CostoUnidad = unidadcosto;
            Total = montototal;
        }

    }
}
