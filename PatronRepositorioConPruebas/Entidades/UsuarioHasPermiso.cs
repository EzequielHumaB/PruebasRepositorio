using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class UsuarioHasPermiso
    {
        [Key]
        public int Usuario_UsuarioId { get; set; }
        public int Persimo_PermisoId { get; set; }

        public UsuarioHasPermiso()
        {
            Usuario_UsuarioId = 0;
            Persimo_PermisoId = 0;
        }
    }
}
