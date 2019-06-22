using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace PatronRepositorioConPruebas.Entidades
{
   public class Cargos
    {
        [Key]
        public int CargoId { get; set; }
        public string NombreCargo { get; set; }
        public int Estado_EstadoId { get; set; }
        public Cargos()
        {
            CargoId = 0;
            NombreCargo = string.Empty;
            Estado_EstadoId = 0;
        }
    }
}
