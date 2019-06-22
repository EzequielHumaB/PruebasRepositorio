using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public int Usuario_UsuarioId { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Proovedor_ProovedorId { get; set; }
        public int TipoComprante_idTipoComprobante { get; set; }
        public double CostoCompra { get; set; }
        public virtual List<DetalleCompra> DetalleCompras { get; set; }


        public Compras()
        {
            CompraId = 0;
            Usuario_UsuarioId = 0;
            FechaCompra = DateTime.Now;
            Proovedor_ProovedorId = 0;
            TipoComprante_idTipoComprobante = 0;
            CostoCompra = 0.0d;
            DetalleCompras = new List<DetalleCompra>();
        }

    }
}
