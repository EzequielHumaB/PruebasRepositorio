using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class Proovedor
    {
        [Key]
        public int IdProovedor { get; set; }
        public int Persona_IdPersona { get; set; }

        public Proovedor()
        {
            IdProovedor = 0;
            Persona_IdPersona = 0;
        }
    }
}
