using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class TipoComprobante
    { 
        [Key]
        public int TipoComprobanteId { get; set; }
        public string NombreComprobante { get; set; }

        public TipoComprobante()
        {
            TipoComprobanteId = 0;
            NombreComprobante = string.Empty;
        }

    }
}
