using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public int Usuario_UsuarioId { get; set; }
        public int Cliente_ClienteId { get; set; }
        public int TipoComprante_idTipoComprante { get; set; }
        public DateTime FechaVenta { get; set; }
        public double igv { get; set; }
        public double SubTotal { get; set; }
        public double CostoVenta { get; set; }
        public virtual List<DetalleVentas> DetalleVentas { get; set; }

        public Ventas()
        {
            VentaId = 0;
            Usuario_UsuarioId = 0;
            Cliente_ClienteId = 0;
            TipoComprante_idTipoComprante = 0;
            FechaVenta = DateTime.Now;
            igv = 0.0d;
            SubTotal = 0.0d;
            CostoVenta = 0.0d;
            DetalleVentas = new List<DetalleVentas>();
        }
    }
}
