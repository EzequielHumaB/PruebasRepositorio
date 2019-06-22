using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class UnidadMedida
    {
        [Key]
        public int UnidadMedidaId { get; set; }
        public string NombreUnidad { get; set; }

        public UnidadMedida()
        {
            UnidadMedidaId = 0;
            NombreUnidad = string.Empty;
        }

    }
}
