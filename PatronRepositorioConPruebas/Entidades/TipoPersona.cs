using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class TipoPersona
    {
        [Key]
        public int idTipoPersona { get; set; }
        public string nombre { get; set; }

        public TipoPersona()
        {
            idTipoPersona = 0;
            nombre = string.Empty;
        }
    }
}
